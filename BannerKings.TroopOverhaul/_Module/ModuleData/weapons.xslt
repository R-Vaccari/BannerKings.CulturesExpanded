<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>



    <xsl:template match="CraftedItem[@id='AR_darshi_axe_t2']/@culture">
        <xsl:attribute name="culture">Culture.darshi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="CraftedItem[@id='AR_darshi_axe_t3']/@culture">
        <xsl:attribute name="culture">Culture.darshi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="CraftedItem[@id='AR_darshi_axe_t4']/@culture">
        <xsl:attribute name="culture">Culture.darshi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="CraftedItem[@id='AR_darshi_axe_t5']/@culture">
        <xsl:attribute name="culture">Culture.darshi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="CraftedItem[@id='AR_empire_mace_1_t2']/@culture">
        <xsl:attribute name="culture">Culture.darshi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="CraftedItem[@id='AR_darshi_mace_1_t2']/@culture">
        <xsl:attribute name="culture">Culture.darshi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="CraftedItem[@id='AR_darshi_mace_3_t3']/@culture">
        <xsl:attribute name="culture">Culture.darshi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="CraftedItem[@id='AR_darshi_mace_4_t4']/@culture">
        <xsl:attribute name="culture">Culture.darshi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="CraftedItem[@id='AR_darshi_mace_5_t4']/@culture">
        <xsl:attribute name="culture">Culture.darshi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="CraftedItem[@id='AR_darshi_mace_5_t5']/@culture">
        <xsl:attribute name="culture">Culture.darshi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="CraftedItem[@id='AR_darshi_2h_mace_t4']/@culture">
        <xsl:attribute name="culture">Culture.darshi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="CraftedItem[@id='AR_darshi_2h_mace_t5']/@culture">
        <xsl:attribute name="culture">Culture.darshi</xsl:attribute>
    </xsl:template>
	
	
	
	<xsl:template match="CraftedItem[@id='AR_shotel_t2']/@culture">
        <xsl:attribute name="culture">Culture.siri</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="CraftedItem[@id='AR_shotel_t3']/@culture">
        <xsl:attribute name="culture">Culture.siri</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="CraftedItem[@id='AR_shotel_t4']/@culture">
        <xsl:attribute name="culture">Culture.siri</xsl:attribute>
    </xsl:template>
	
</xsl:stylesheet>