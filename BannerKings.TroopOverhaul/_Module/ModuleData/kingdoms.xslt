<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>

    </xsl:template>
	
	
	<xsl:template match="Kingdom[@id='vlandia']/@title">
        <xsl:attribute name="title">Kyningdóm Wilundinges</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='vlandia']/@name">
        <xsl:attribute name="name">Vlandia</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='vlandia']/@short_name">
        <xsl:attribute name="short_name">kyningdóm Wilundinges</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='vlandia']/@ruler_title">
        <xsl:attribute name="ruler_title"></xsl:attribute>
    </xsl:template>
	
	
	
	<xsl:template match="Kingdom[@id='battania']/@title">
        <xsl:attribute name="title">Brenhiniaeth Battanwr</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='battania']/@name">
        <xsl:attribute name="name">Battania</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='battania']/@short_name">
        <xsl:attribute name="short_name">brenhiniaeth Battanwr</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='battania']/@ruler_title">
        <xsl:attribute name="ruler_title"></xsl:attribute>
    </xsl:template>
	
	
	
	<xsl:template match="Kingdom[@id='sturgia']/@title">
        <xsl:attribute name="title">Sturgiske Knyazivstvo</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='sturgia']/@name">
        <xsl:attribute name="name">Sturgia</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='sturgia']/@short_name">
        <xsl:attribute name="short_name">sturgiske Knyazivstvo</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='sturgia']/@ruler_title">
        <xsl:attribute name="ruler_title"></xsl:attribute>
    </xsl:template>
	
	
	
	<xsl:template match="Kingdom[@id='aserai']/@title">
        <xsl:attribute name="title">Saljuqiyan-i Aserai</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='aserai']/@name">
        <xsl:attribute name="name">Aserai</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='aserai']/@short_name">
        <xsl:attribute name="short_name">saljuqiyan-i Aserai</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='aserai']/@ruler_title">
        <xsl:attribute name="ruler_title"></xsl:attribute>
    </xsl:template>
	
	
	
	<xsl:template match="Kingdom[@id='khuzait']/@title">
        <xsl:attribute name="title">Yeke Khuzait Ulus</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='khuzait']/@name">
        <xsl:attribute name="name">Khuzaits</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='khuzait']/@short_name">
        <xsl:attribute name="short_name">yeke Khuzait Ulus</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='khuzait']/@ruler_title">
        <xsl:attribute name="ruler_title"></xsl:attribute>
    </xsl:template>
	
	

    <xsl:template match="Kingdom[@id='empire']/@title">
        <xsl:attribute name="title">Politeia ton Calradoi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='empire']/@name">
        <xsl:attribute name="name">Northern Calradoi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='empire']/@short_name">
        <xsl:attribute name="short_name">politeia ton Calradoi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='empire']/@ruler_title">
        <xsl:attribute name="ruler_title"></xsl:attribute>
    </xsl:template>
	
	
	
	<xsl:template match="Kingdom[@id='empire_w']/@title">
        <xsl:attribute name="title">Diktatoría ton Calradoi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='empire_w']/@name">
        <xsl:attribute name="name">Western Calradoi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='empire_w']/@short_name">
        <xsl:attribute name="short_name">diktatoría ton Calradoi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='empire_w']/@ruler_title">
        <xsl:attribute name="ruler_title"></xsl:attribute>
    </xsl:template>
	
	
	
	<xsl:template match="Kingdom[@id='empire_s']/@title">
        <xsl:attribute name="title">Basileia ton Calradoi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Kingdom[@id='empire_s']/@name">
        <xsl:attribute name="name">Southern Calradoi</xsl:attribute>
    </xsl:template>
	
	 <xsl:template match="Kingdom[@id='empire_s']/@short_name">
        <xsl:attribute name="short_name">basileia ton Calradoi</xsl:attribute>
    </xsl:template>

	<xsl:template match="Kingdom[@id='empire_s']/@ruler_title">
        <xsl:attribute name="ruler_title"></xsl:attribute>
    </xsl:template>
   

</xsl:stylesheet>