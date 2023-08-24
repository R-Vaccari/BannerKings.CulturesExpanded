<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>


	<xsl:template match='MBPartyTemplate[@id="kingdom_hero_party_mercenary_sturgia_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="40" max_value="40" troop="NPCCharacter.bk_skolder" />
        </stacks>
    </xsl:template>
	
	<xsl:template match='MBPartyTemplate[@id="kingdom_hero_party_mercenary_vlandia_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="40" max_value="40" troop="NPCCharacter.bk_golden_boar" />
        </stacks>
    </xsl:template>
	
	<xsl:template match='MBPartyTemplate[@id="kingdom_hero_party_outlaw_empire_e_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="40" max_value="40" troop="NPCCharacter.bk_ember" />
        </stacks>
    </xsl:template>
	
	<xsl:template match='MBPartyTemplate[@id="kingdom_hero_party_jawwal_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="40" max_value="40" troop="NPCCharacter.bk_jawwal" />
        </stacks>
    </xsl:template>
	
	<xsl:template match='MBPartyTemplate[@id="kingdom_hero_party_mercenary_empire_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="40" max_value="40" troop="NPCCharacter.bk_legion" />
        </stacks>
    </xsl:template>
	
	<xsl:template match='MBPartyTemplate[@id="kingdom_hero_party_eleftheroi_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="40" max_value="40" troop="NPCCharacter.bk_eleftheroi" />
        </stacks>
    </xsl:template>
	
	<xsl:template match='MBPartyTemplate[@id="kingdom_hero_party_outlaw_empire_w_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="40" max_value="40" troop="NPCCharacter.bk_hand" />
        </stacks>
    </xsl:template>
	
	
	
   
    <xsl:template match='MBPartyTemplate[@id="rebels_empire_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="1" max_value="1" troop="NPCCharacter.bk_imperial_levy" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="rebels_aserai_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="1" max_value="1" troop="NPCCharacter.bk_aserai_levy" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="rebels_sturgia_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="1" max_value="1" troop="NPCCharacter.bk_sturgian_levy" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="rebels_vlandia_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="1" max_value="1" troop="NPCCharacter.bk_vlandia_levy" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="rebels_battania_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="1" max_value="1" troop="NPCCharacter.bk_battanian_levy" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="rebels_khuzait_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="1" max_value="1" troop="NPCCharacter.bk_khuzait_levy" />
        </stacks>
    </xsl:template>
  
    <xsl:template match='MBPartyTemplate[@id="vassal_reward_troops_empire"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="1" max_value="1" troop="NPCCharacter.bk_imperial_cataphract" />
            <PartyTemplateStack min_value="5" max_value="5" troop="NPCCharacter.bk_imperial_squire" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="vassal_reward_troops_aserai"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="1" max_value="1" troop="NPCCharacter.bk_aserai_faaris" />
            <PartyTemplateStack min_value="5" max_value="5" troop="NPCCharacter.bk_aserai_squire" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="vassal_reward_troops_sturgia"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="1" max_value="1" troop="NPCCharacter.bk_sturgia_druzhinnik" />
            <PartyTemplateStack min_value="5" max_value="5" troop="NPCCharacter.bk_sturgia_squire" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="vassal_reward_troops_battania"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="1" max_value="1" troop="NPCCharacter.bk_battanian_fian" />
            <PartyTemplateStack min_value="5" max_value="5" troop="NPCCharacter.bk_battanian_squire" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="vassal_reward_troops_vlandia"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="1" max_value="1" troop="NPCCharacter.bk_vlandia_knight" />
            <PartyTemplateStack min_value="5" max_value="5" troop="NPCCharacter.bk_vlandia_squire" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="vassal_reward_troops_khuzait"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="1" max_value="1" troop="NPCCharacter.bk_khuzait_kheshig" />
            <PartyTemplateStack min_value="5" max_value="5" troop="NPCCharacter.bk_khuzait_squire" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="kingdom_hero_party_empire_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="6" max_value="16" troop="NPCCharacter.bk_imperial_levy" />
            <PartyTemplateStack min_value="4" max_value="8" troop="NPCCharacter.bk_imperial_militiaman" />
            <PartyTemplateStack min_value="4" max_value="6" troop="NPCCharacter.bk_imperial_peltast" />
            <PartyTemplateStack min_value="2" max_value="6" troop="NPCCharacter.bk_imperial_levy_archer" /> 
            <PartyTemplateStack min_value="2" max_value="4" troop="NPCCharacter.bk_imperial_militiaman_archer" />
			<PartyTemplateStack min_value="4" max_value="6" troop="NPCCharacter.bk_imperial_squire" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="kingdom_hero_party_sturgia_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="6" max_value="16" troop="NPCCharacter.bk_sturgian_levy" />
            <PartyTemplateStack min_value="6" max_value="10" troop="NPCCharacter.bk_sturgian_militiaman" />
            <PartyTemplateStack min_value="2" max_value="6" troop="NPCCharacter.bk_sturgian_levy_archer" /> 
            <PartyTemplateStack min_value="2" max_value="4" troop="NPCCharacter.bk_sturgian_militiaman_archer" />
			<PartyTemplateStack min_value="4" max_value="6" troop="NPCCharacter.bk_sturgia_squire" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="kingdom_hero_party_aserai_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="6" max_value="16" troop="NPCCharacter.bk_aserai_levy" />
            <PartyTemplateStack min_value="6" max_value="10" troop="NPCCharacter.bk_aserai_militiaman" />
            <PartyTemplateStack min_value="2" max_value="6" troop="NPCCharacter.bk_aserai_levy_archer" /> 
            <PartyTemplateStack min_value="2" max_value="4" troop="NPCCharacter.bk_aserai_militiaman_archer" />
			<PartyTemplateStack min_value="4" max_value="6" troop="NPCCharacter.bk_aserai_squire" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="kingdom_hero_party_vlandia_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="6" max_value="16" troop="NPCCharacter.bk_vlandia_levy" />
            <PartyTemplateStack min_value="6" max_value="10" troop="NPCCharacter.bk_vlandia_militiaman" />
            <PartyTemplateStack min_value="2" max_value="6" troop="NPCCharacter.bk_vlandia_levy_crossbow" /> 
            <PartyTemplateStack min_value="2" max_value="4" troop="NPCCharacter.bk_vlandia_militiaman_crossbow" />
			<PartyTemplateStack min_value="4" max_value="6" troop="NPCCharacter.bk_vlandia_squire" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="kingdom_hero_party_battania_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="6" max_value="16" troop="NPCCharacter.bk_battanian_levy" />
            <PartyTemplateStack min_value="4" max_value="8" troop="NPCCharacter.bk_battanian_militiaman" />
            <PartyTemplateStack min_value="4" max_value="6" troop="NPCCharacter.bk_battanian_skirmisher" />
            <PartyTemplateStack min_value="2" max_value="6" troop="NPCCharacter.bk_battanian_levy_archer" /> 
            <PartyTemplateStack min_value="2" max_value="4" troop="NPCCharacter.bk_battanian_militiaman_archer" />
			<PartyTemplateStack min_value="4" max_value="6" troop="NPCCharacter.bk_battanian_squire" />
        </stacks>
    </xsl:template>
    <xsl:template match='MBPartyTemplate[@id="kingdom_hero_party_khuzait_template"]/stacks'>
        <stacks>
            <PartyTemplateStack min_value="6" max_value="16" troop="NPCCharacter.bk_khuzait_levy" />
            <PartyTemplateStack min_value="6" max_value="10" troop="NPCCharacter.bk_khuzait_militiaman" />
            <PartyTemplateStack min_value="2" max_value="6" troop="NPCCharacter.bk_khuzait_militiaman_lancer" /> 
            <PartyTemplateStack min_value="2" max_value="4" troop="NPCCharacter.bk_khuzait_militiaman_infantry" />
			<PartyTemplateStack min_value="4" max_value="6" troop="NPCCharacter.bk_khuzait_squire" />
        </stacks>
    </xsl:template>


</xsl:stylesheet>