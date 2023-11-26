<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='OneHandedSword']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
				<AvailablePiece id="kanic_blade_1"/>
				<AvailablePiece id="kanic_blade_2"/>
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='OneHandedBastardSword']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
				<AvailablePiece id="kanic_blade_1"/>
				<AvailablePiece id="kanic_blade_2"/>
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='OneHandedBastardSwordAlternative']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
				<AvailablePiece id="kanic_blade_1"/>
				<AvailablePiece id="kanic_blade_2"/>
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='TwoHandedSword']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>

            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='Dagger']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
			
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='ThrowingKnife']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
			
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='OneHandedAxe']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
			
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='OneHandedBastardAxe']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
			
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='OneHandedBastardAxeAlternative']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
			
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='TwoHandedAxe']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
			
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='ThrowingAxe']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
			
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='OneHandedPolearm']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
			
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='OneHandedPolearm_JavelinAlternative']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
			
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='TwoHandedPolearm']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
				<AvailablePiece id="spear_blade_throw_single"/>
				<AvailablePiece id="bk_2h_mahogany"/>
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='TwoHandedPolearm_Couchable']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
				<AvailablePiece id="bk_2h_mahogany"/>
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='TwoHandedPolearm_Pike']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>

            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='TwoHandedPolearm_Bracing']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>

            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='TwoHandedPolearm_Thrown']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
				<AvailablePiece id="spear_blade_throw_single"/>
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='Javelin']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>
				<AvailablePiece id="spear_blade_throw_single"/>
            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="WeaponDescription[@id='Mace']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>

            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>

	<xsl:template match="WeaponDescription[@id='TwoHandedMace']/AvailablePieces">
        <xsl:copy>
            <xsl:copy-of select="@*"/>

            <xsl:copy-of select="node()"/>
        </xsl:copy>
    </xsl:template>

</xsl:stylesheet>

