using HarmonyLib;
using SandBox;
using SandBox.View.Map;
using System;
using System.Linq;
using System.Reflection;
using TaleWorlds.CampaignSystem.Map;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.Core;
using TaleWorlds.Engine;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade.View;

namespace BannerKings.CulturesExpanded.Patches
{
    internal class WaterPatch
    {
        [HarmonyPatch(typeof(MapScene))]
        public class MapScenePatch
        {
            [HarmonyPostfix]
            [HarmonyPatch("GetNavigationMeshIndexOfTerrainType")]
            public static void GetNavigationMeshIndexOfTerrainTypePostfix(TerrainType terrainType, ref int __result)
            {
                if (terrainType == TerrainType.Swamp)
                {
                    __result = 9;
                }
            }

            [HarmonyPostfix]
            [HarmonyPatch("GetFaceTerrainType")]
            public static void GetFaceTerrainTypePostfix(PathFaceRecord navMeshFace, MapScene __instance, ref TerrainType __result)
            {
                if (navMeshFace.IsValid() && __instance.Scene.GetIdOfNavMeshFace(navMeshFace.FaceIndex) == 9)
                {
                    __result = TerrainType.Swamp;
                }
            }

            [HarmonyPostfix]
            [HarmonyPatch("GetHeightAtPoint")]
            public static void GetTerrainHeightPatch(MapScene __instance, Vec2 point, ref float height)
            {
                if (height < __instance.Scene.GetWaterLevel())
                {
                    height = __instance.Scene.GetWaterLevel();
                }
            }

            [HarmonyPostfix]
            [HarmonyPatch("GetTerrainHeightAndNormal")]
            public static void GetTerrainHeightAndNormalPatch(MapScene __instance, Vec2 position, ref float height, out Vec3 normal)
            {
                __instance.Scene.GetTerrainHeightAndNormal(position, out height, out normal);
                if (height < __instance.Scene.GetWaterLevel())
                {
                    height = __instance.Scene.GetWaterLevel();
                }
            }

            [HarmonyPrefix]
            [HarmonyPatch(typeof(MapScene), "GetPathBetweenAIFaces")]
            public static void MapScene_GetPathBetweenAIFaces_Patch(MapScene __instance, PathFaceRecord startingFace, PathFaceRecord endingFace, Vec2 startingPosition, Vec2 endingPosition, float agentRadius, NavigationPath path, ref int[] excludedFaceIds)
            {
                MobileParty party = MobileParty.All.FirstOrDefault(x => 
                x.Ai.Path == path
                );
                if (party != null && party.IsBandit)
                {
                    excludedFaceIds = new int[] { 9 };
                   /* List<int> excluded = new List<int>();
                    foreach (Vec2 pos in party.Ai.Path.PathPoints)
                    {
                        PathFaceRecord face = TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper.GetFaceIndex(pos);
                        if (TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper.GetFaceTerrainType(face) == TerrainType.Swamp)
                        {
                            excluded.Add(face.FaceIndex);
                        }
                    }

                    if (excluded.Count > 0) excludedFaceIds = excluded.ToArray();*/
                }
            }
        }

        [HarmonyPatch(typeof(MapScreen))]
        public class MapScreenPatch
        {
            [HarmonyPrefix]
            [HarmonyPatch("CheckCursorState")]
            public static bool CheckCursorStatePatch(MapScreen __instance)
            {
                Vec3 zero = Vec3.Zero;
                Vec3 zero2 = Vec3.Zero;
                __instance.SceneLayer.SceneView.TranslateMouse(ref zero, ref zero2, -1f);
                Vec3 vec = zero;
                Vec3 vec2 = zero2;
                PathFaceRecord faceRecord = PathFaceRecord.NullFaceRecord;
                float num;
                Vec3 vec3;
                __instance.GetCursorIntersectionPoint(ref vec, ref vec2, out num, out vec3, ref faceRecord, BodyFlags.CommonFocusRayCastExcludeFlags);
                TerrainType current = TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper.GetFaceTerrainType(faceRecord);

                bool flag = TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper.AreFacesOnSameIsland(faceRecord,
                    MobileParty.MainParty.CurrentNavigationFace, false);
                if (flag || current == TerrainType.Swamp) __instance.SceneLayer.ActiveCursor = TaleWorlds.ScreenSystem.CursorType.Default;
                else __instance.SceneLayer.ActiveCursor = TaleWorlds.ScreenSystem.CursorType.Disabled;

                return false;
            }
        }

        [HarmonyPatch(typeof(PartyBase))]
        public class PartyBasePatch
        {
            [HarmonyPostfix]
            [HarmonyPatch("IsPositionOkForTraveling")]
            public static void IsPositionOkForTravelingPatch(PartyBase __instance, ref bool __result, Vec2 position)
            {
                if (__result == false)
                {
                    IMapScene mapSceneWrapper = TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper;
                    PathFaceRecord faceIndex = mapSceneWrapper.GetFaceIndex(position);
                    if (!faceIndex.IsValid())
                    {
                        return;
                    }
                    if (mapSceneWrapper.GetFaceTerrainType(faceIndex) == TerrainType.Swamp)
                        __result = true;
                }
            }
        }

        [HarmonyPatch(typeof(MobileParty), "HourlyTick")]
        public class OnAiTickInternalPatch
        {
            public static MethodInfo SetVisualsMethodInfo = AccessTools.Method(typeof(PartyVisual), "set_MountAgentVisuals");
            public static MethodInfo GetBannerOfCharacterMethodInfo = AccessTools.Method(typeof(PartyVisual), "GetBannerOfCharacter");

            private static void SetVisualsNull(PartyVisual instance)
            {
                SetVisualsMethodInfo.Invoke(instance, new object[] { null });
            }

            private static MetaMesh GetBannerOfCharacter(Banner banner, string bannerMeshName)
            {
                return (MetaMesh)GetBannerOfCharacterMethodInfo.Invoke(null, new object[] { banner, bannerMeshName });
            }

            public static void Postfix(MobileParty __instance)
            {
                try
                {
                    if (__instance.IsActive && __instance.IsMoving)
                    {
                        PartyVisual visuals = PartyVisualManager.Current.GetVisualOfParty(__instance.Party);
                        AgentVisuals humanAgentVisuals = visuals.HumanAgentVisuals;
                        if (humanAgentVisuals != null)
                        {
                            if (TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper.GetFaceTerrainType(__instance.CurrentNavigationFace) == TerrainType.Swamp
                                && visuals.HumanAgentVisuals.GetEntity().GetVisibilityExcludeParents())
                            {
                                if (visuals.StrategicEntity.ChildCount == 0)
                                {
                                    GameEntity gameEntity = GameEntity.CreateEmpty(visuals.StrategicEntity.Scene, true);
                                    if (__instance.IsCaravan)
                                    {
                                        MatrixFrame identity = MatrixFrame.Identity;
                                        identity.rotation.ApplyScaleLocal(1f);
                                        identity.Rotate(1.4f, Vec3.Up);
                                        gameEntity.AddMultiMesh(MetaMesh.GetCopy("mi_ship_2", true, false), true);
                                        gameEntity.SetFrame(ref identity);
                                    }
                                    else
                                    {
                                        MatrixFrame identity2 = MatrixFrame.Identity;
                                        identity2.rotation.ApplyScaleLocal(0.08f);
                                        if (__instance.Army != null)
                                        {
                                            if (__instance.Army.LeaderParty != __instance)
                                            {
                                                identity2.rotation.ApplyScaleLocal(0.8f);
                                            }
                                        }
                                        gameEntity.AddMultiMesh(MetaMesh.GetCopy("ship_a", true, false), true);
                                        gameEntity.SetFrame(ref identity2);
                                    }

                                    if (gameEntity.ChildCount == 0)
                                    {
                                        gameEntity.AddChild(GameEntity.CreateEmpty(visuals.StrategicEntity.Scene, true));

                                        if (__instance.LeaderHero != null)
                                        {
                                            if (__instance.LeaderHero.ClanBanner != null)
                                            {
                                                string text = __instance.LeaderHero.ClanBanner.Serialize();
                                                MetaMesh bannerOfCharacter = GetBannerOfCharacter(new Banner(text), "campaign_flag");
                                                gameEntity.GetChild(0).AddMultiMesh(bannerOfCharacter, true);


                                                MatrixFrame identity3 = MatrixFrame.Identity;
                                                identity3.rotation.ApplyScaleLocal(4f);
                                                identity3.Advance(-0.21f);
                                                identity3.Strafe(0.03f);
                                                gameEntity.GetChild(0).SetFrame(ref identity3);
                                            }
                                        }
                                    }

                                    visuals.StrategicEntity.AddChild(gameEntity, false);

                                }

                                if (visuals.HumanAgentVisuals.GetEntity().GetVisibilityExcludeParents())
                                {
                                    visuals.HumanAgentVisuals.GetEntity().SetVisibilityExcludeParents(false);

                                    AgentVisuals mountAgentVisuals = visuals.MountAgentVisuals;

                                    if (mountAgentVisuals != null)
                                    {
                                        visuals.MountAgentVisuals.Reset();
                                        SetVisualsNull(visuals);
                                    }

                                    AgentVisuals caravanMountAgentVisuals = visuals.CaravanMountAgentVisuals;
                                    if (caravanMountAgentVisuals != null)
                                    {
                                        visuals.CaravanMountAgentVisuals.GetEntity().SetVisibilityExcludeParents(false);
                                    }
                                }

                            }
                        }
                        if (TaleWorlds.CampaignSystem.Campaign.Current.MapSceneWrapper.GetFaceTerrainType(__instance.CurrentNavigationFace) != TerrainType.Swamp && visuals.StrategicEntity.ChildCount > 0)
                        {
                            __instance.Party.SetVisualAsDirty();
                        }
                    }
                }
                catch (Exception e)
                {
                    MBDebug.ShowWarning(string.Format("Error while trying to show party as ship. Party: [{0}]\nException: [{1}]", __instance.Name, e.Message));
                }
            }
        }
    }
}
