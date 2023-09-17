<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="Culture[@id='empire']/@elite_basic_troop">
        <xsl:attribute name="elite_basic_troop">NPCCharacter.bk_imperial_squire</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='empire']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_imperial_levy</xsl:attribute>
    </xsl:template>
	
	
	<xsl:template match="Culture[@id='empire']/@melee_militia_troop">
        <xsl:attribute name="melee_militia_troop">NPCCharacter.bk_imperial_levy</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='empire']/@ranged_militia_troop">
        <xsl:attribute name="ranged_militia_troop">NPCCharacter.bk_imperial_levy_archer</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='empire']/@melee_elite_militia_troop">
        <xsl:attribute name="melee_elite_militia_troop">NPCCharacter.bk_imperial_militiaman</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='empire']/@ranged_elite_militia_troop">
        <xsl:attribute name="ranged_elite_militia_troop">NPCCharacter.bk_imperial_militiaman_archer</xsl:attribute>
    </xsl:template>
	

    <xsl:template match="Culture[@id='aserai']/@elite_basic_troop">
        <xsl:attribute name="elite_basic_troop">NPCCharacter.bk_aserai_squire</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='aserai']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_aserai_levy</xsl:attribute>
    </xsl:template>
	
	
	<xsl:template match="Culture[@id='aserai']/@melee_militia_troop">
        <xsl:attribute name="melee_militia_troop">NPCCharacter.bk_aserai_levy</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='aserai']/@ranged_militia_troop">
        <xsl:attribute name="ranged_militia_troop">NPCCharacter.bk_aserai_levy_archer</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='aserai']/@melee_elite_militia_troop">
        <xsl:attribute name="melee_elite_militia_troop">NPCCharacter.bk_aserai_militiaman</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='aserai']/@ranged_elite_militia_troop">
        <xsl:attribute name="ranged_elite_militia_troop">NPCCharacter.bk_aserai_militiaman_archer</xsl:attribute>
    </xsl:template>
	
	

    <xsl:template match="Culture[@id='sturgia']/@elite_basic_troop">
        <xsl:attribute name="elite_basic_troop">NPCCharacter.bk_sturgia_squire</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='sturgia']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_sturgian_levy</xsl:attribute>
    </xsl:template>
	
	
	<xsl:template match="Culture[@id='sturgia']/@melee_militia_troop">
        <xsl:attribute name="melee_militia_troop">NPCCharacter.bk_sturgian_levy</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='sturgia']/@ranged_militia_troop">
        <xsl:attribute name="ranged_militia_troop">NPCCharacter.bk_sturgian_levy_archer</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='sturgia']/@melee_elite_militia_troop">
        <xsl:attribute name="melee_elite_militia_troop">NPCCharacter.bk_sturgian_militiaman</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='sturgia']/@ranged_elite_militia_troop">
        <xsl:attribute name="ranged_elite_militia_troop">NPCCharacter.bk_sturgian_militiaman_archer</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='empire']/basic_mercenary_troops">
        <basic_mercenary_troops>
            <template name="NPCCharacter.bk_sturgia_mercenary" />
        </basic_mercenary_troops>
    </xsl:template>
	
	

    <xsl:template match="Culture[@id='vlandia']/@elite_basic_troop">
        <xsl:attribute name="elite_basic_troop">NPCCharacter.bk_vlandia_squire</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='vlandia']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_vlandia_levy</xsl:attribute>
    </xsl:template>
	
	
	<xsl:template match="Culture[@id='vlandia']/@melee_militia_troop">
        <xsl:attribute name="melee_militia_troop">NPCCharacter.bk_vlandia_levy</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='vlandia']/@ranged_militia_troop">
        <xsl:attribute name="ranged_militia_troop">NPCCharacter.bk_vlandia_levy_crossbow</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='vlandia']/@melee_elite_militia_troop">
        <xsl:attribute name="melee_elite_militia_troop">NPCCharacter.bk_vlandia_militiaman</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='vlandia']/@ranged_elite_militia_troop">
        <xsl:attribute name="ranged_elite_militia_troop">NPCCharacter.bk_vlandia_militiaman_crossbow</xsl:attribute>
    </xsl:template>
	
	
	
    <xsl:template match="Culture[@id='battania']/@elite_basic_troop">
        <xsl:attribute name="elite_basic_troop">NPCCharacter.bk_battanian_squire</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='battania']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_battanian_levy</xsl:attribute>
    </xsl:template>
	
	
	<xsl:template match="Culture[@id='battania']/@melee_militia_troop">
        <xsl:attribute name="melee_militia_troop">NPCCharacter.bk_battanian_levy</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='battania']/@ranged_militia_troop">
        <xsl:attribute name="ranged_militia_troop">NPCCharacter.bk_battanian_levy_archer</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='battania']/@melee_elite_militia_troop">
        <xsl:attribute name="melee_elite_militia_troop">NPCCharacter.bk_battanian_militiaman</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='battania']/@ranged_elite_militia_troop">
        <xsl:attribute name="ranged_elite_militia_troop">NPCCharacter.bk_battanian_militiaman_archer</xsl:attribute>
    </xsl:template>
	
	

    <xsl:template match="Culture[@id='khuzait']/@elite_basic_troop">
        <xsl:attribute name="elite_basic_troop">NPCCharacter.bk_khuzait_squire</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='khuzait']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_khuzait_levy</xsl:attribute>
    </xsl:template>
	
	
	<xsl:template match="Culture[@id='khuzait']/@melee_militia_troop">
        <xsl:attribute name="melee_militia_troop">NPCCharacter.bk_khuzait_militiaman_lancer</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='khuzait']/@ranged_militia_troop">
        <xsl:attribute name="ranged_militia_troop">NPCCharacter.bk_khuzait_levy</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='khuzait']/@melee_elite_militia_troop">
        <xsl:attribute name="melee_elite_militia_troop">NPCCharacter.bk_khuzait_militiaman_infantry</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='khuzait']/@ranged_elite_militia_troop">
        <xsl:attribute name="ranged_elite_militia_troop">NPCCharacter.bk_khuzait_militiaman</xsl:attribute>
    </xsl:template>
	
</xsl:stylesheet>