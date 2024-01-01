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
	
	<xsl:template match="Culture[@id='empire']/@name">
        <xsl:attribute name="name">Calradoi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='empire']/@militia_party_template">
        <xsl:attribute name="militia_party_template">PartyTemplate.bkce_militia_empire_template</xsl:attribute>
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
	
	<xsl:template match="Culture[@id='empire']/basic_mercenary_troops">
        <basic_mercenary_troops>
            <template name="NPCCharacter.bk_imperial_mercenary" />
        </basic_mercenary_troops>
    </xsl:template>
	
	

    <xsl:template match="Culture[@id='aserai']/@elite_basic_troop">
        <xsl:attribute name="elite_basic_troop">NPCCharacter.bk_aserai_squire</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='aserai']/@militia_party_template">
        <xsl:attribute name="militia_party_template">PartyTemplate.bkce_militia_aserai_template</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='aserai']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_aserai_levy</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='aserai']/@name">
        <xsl:attribute name="name">Nahawasi</xsl:attribute>
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
	
	<xsl:template match="Culture[@id='sturgia']/@militia_party_template">
        <xsl:attribute name="militia_party_template">PartyTemplate.bkce_militia_sturgia_template</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='sturgia']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_sturgian_levy</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='sturgia']/@name">
        <xsl:attribute name="name">Sturgiske</xsl:attribute>
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
	
	<xsl:template match="Culture[@id='sturgia']/basic_mercenary_troops">
        <basic_mercenary_troops>
            <template name="NPCCharacter.bk_sturgia_mercenary" />
			<template name="NPCCharacter.bk_nord_mercenary" />
        </basic_mercenary_troops>
    </xsl:template>
	
	<xsl:template match="Culture[@id='sturgia']/notable_and_wanderer_templates">
        <notable_and_wanderer_templates>
          <template name="NPCCharacter.spc_wanderer_sturgia_0" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_1" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_2" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_3" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_4" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_5" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_6" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_7" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_8" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_9" />
		  <template name="NPCCharacter.spc_notable_sturgia_0" />
		  <template name="NPCCharacter.spc_notable_sturgia_0b" />
		  <template name="NPCCharacter.spc_notable_sturgia_1" />
		  <template name="NPCCharacter.spc_notable_sturgia_2" />
		  <template name="NPCCharacter.spc_notable_sturgia_2b" />
		  <template name="NPCCharacter.spc_notable_sturgia_3" />
		  <template name="NPCCharacter.spc_notable_sturgia_3b" />
		  <template name="NPCCharacter.spc_notable_sturgia_3c" />
		  <template name="NPCCharacter.spc_notable_sturgia_4" />
		  <template name="NPCCharacter.spc_notable_sturgia_5" />
		  <template name="NPCCharacter.spc_notable_sturgia_6" />
		  <template name="NPCCharacter.spc_notable_sturgia_7" />
		  <template name="NPCCharacter.spc_notable_sturgia_8" />
		  <template name="NPCCharacter.spc_notable_sturgia_9" />
		  <template name="NPCCharacter.spc_notable_sturgia_10" />
		  <template name="NPCCharacter.spc_sturgia_headman_1" />
		  <template name="NPCCharacter.spc_sturgia_headman_2" />
		  <template name="NPCCharacter.spc_sturgia_headman_3" />
		  <template name="NPCCharacter.spc_notable_vakken_0" />
        </notable_and_wanderer_templates>
    </xsl:template>
	
	

    <xsl:template match="Culture[@id='vlandia']/@elite_basic_troop">
        <xsl:attribute name="elite_basic_troop">NPCCharacter.bk_vlandia_squire</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='vlandia']/@militia_party_template">
        <xsl:attribute name="militia_party_template">PartyTemplate.bkce_militia_vlandia_template</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='vlandia']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_vlandia_levy</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='vlandia']/@name">
        <xsl:attribute name="name">Wilunding</xsl:attribute>
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
	
	<xsl:template match="Culture[@id='battania']/@militia_party_template">
        <xsl:attribute name="militia_party_template">PartyTemplate.bkce_militia_battania_template</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='battania']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_battanian_levy</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='battania']/@name">
        <xsl:attribute name="name">Battaneid</xsl:attribute>
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
	
	<xsl:template match="Culture[@id='khuzait']/@militia_party_template">
        <xsl:attribute name="militia_party_template">PartyTemplate.bkce_militia_khuzait_template</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='khuzait']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_khuzait_levy</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='khuzait']/@name">
        <xsl:attribute name="name">Devseg</xsl:attribute>
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