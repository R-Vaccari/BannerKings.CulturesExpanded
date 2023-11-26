<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="CraftingTemplate[@id='Javelin']/@hidden_piece_types_on_holster"/>

	<xsl:template match="CraftingTemplate[@id='Javelin']/@item_holsters">
		<xsl:attribute name='item_holsters'>twb_javelins:twb_javelins_2:twb_javelins_3:twb_javelins_4</xsl:attribute>
	</xsl:template>

    <xsl:template match="CraftingTemplate[@id='OneHandedSword']/UsablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
				<UsablePiece piece_id="kanic_blade_1"/>
				<UsablePiece piece_id="kanic_blade_2"/>
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="CraftingTemplate[@id='TwoHandedSword']/UsablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>

            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="CraftingTemplate[@id='Dagger']/UsablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
            
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="CraftingTemplate[@id='ThrowingKnife']/UsablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
            
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="CraftingTemplate[@id='OneHandedAxe']/UsablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
            
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="CraftingTemplate[@id='TwoHandedAxe']/UsablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
            
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="CraftingTemplate[@id='ThrowingAxe']/UsablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
            
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="CraftingTemplate[@id='TwoHandedPolearm']/UsablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
                <UsablePiece piece_id="bk_2h_mahogany"/>
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="CraftingTemplate[@id='Pike']/UsablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>

            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="CraftingTemplate[@id='Javelin']/UsablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
                <UsablePiece piece_id="spear_blade_throw_single"/>
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="CraftingTemplate[@id='Mace']/UsablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
            
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="CraftingTemplate[@id='TwoHandedMace']/UsablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
            
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
</xsl:stylesheet>