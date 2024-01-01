<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

	
	<xsl:template match="Settlement[@id='castle_A1']/@owner">
        <xsl:attribute name='owner'>Faction.bk_clan_kannic_2</xsl:attribute>
    </xsl:template>
	

	<xsl:template match="Settlement[@id='town_A2']/@owner">
        <xsl:attribute name='owner'>Faction.fulq</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_S7']/@owner">
        <xsl:attribute name='owner'>Faction.bk_clan_jumne_4</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_S1']/@owner">
        <xsl:attribute name='owner'>Faction.clan_sturgia_5</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_V9']/@owner">
        <xsl:attribute name='owner'>Faction.bk_clan_jumne_3</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_V5']/@owner">
        <xsl:attribute name='owner'>Faction.bk_clan_jumne_1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_V6']/@owner">
        <xsl:attribute name='owner'>Faction.bk_clan_jumne_2</xsl:attribute>
    </xsl:template>
	

</xsl:stylesheet>

