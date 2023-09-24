<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="Settlement[@id='castle_village_V1_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.salt_mine</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_village_V6_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.flax_plant</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_village_V6_2']/@text">
        <xsl:attribute name='text'>Deriat sits between the Bay of Varcheg and the ridges of the Ebor peninsula. The soil is moist from the northern humid winds and the flowing streams from the Ebor hills, making it ideal to grow flax.</xsl:attribute>
    </xsl:template>
	
	
	<xsl:template match="Settlement[@id='village_V8_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.fisherman</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='village_V2_3']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.vlandian_horse_ranch</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='village_V2_3']/@text">
        <xsl:attribute name='text'>Fregian sits on the flatlands north of Pravend, where the warmth of the Vlandian south begins to give way to the chills of the north. Ample pastureland makes it ideal for raising horses.</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_village_V7_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.lumberjack</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_village_V7_1']/@text">
        <xsl:attribute name='text'>Talivel lies in the middle of the Trand valley in the heartland of Calradia. The thick woods are harvested here and provide ample material for the neighbouring towns.</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_village_V5_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_village_V5_1']/@text">
        <xsl:attribute name='text'>Tirby sits in the cold misty waters that lie off of the Ebor peninsula. Villagers raise sheep in the hills at the tip of the peninsula, as wool is highly sought after in the Ebor towns as protection against the cold winds.</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='village_V2_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='village_V2_1']/@text">
        <xsl:attribute name='text'>Mareiven sits on the steep wooded slopes of the Rhennod mountains, overlooking the Ocspool. The steep land favors raising sheep, as the Battanians have done before the Wilunding settlement.</xsl:attribute>
    </xsl:template>
	
	
	
	
	
	<xsl:template match="Settlement[@id='castle_village_B7_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.sheep_farm</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_village_B7_1']/@text">
        <xsl:attribute name='text'>Aster sits in a shallow valley between the hills of the northeastern Uchalion and the Rock of Glanys. Villagers raise sheep, who thrive on the steeps of the nearby hills.</xsl:attribute>
    </xsl:template>
   
    <xsl:template match="Settlement[@id='village_B5_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='village_B5_2']/@text">
        <xsl:attribute name='text'>Gainseth sits in a dark valley beneath the Rhennod hills on the eastern edge of the Uchalion massif. Folks here raise highland cattle, who graze on the open pastures and hillsides.</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_village_B2_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_village_B2_1']/@text">
        <xsl:attribute name='text'>Llanoc Hen sits in a ridge in the heights of the Uchalion massif. Open pastures make for good land to raise the traditional highland cattle. Villagers overlook two passes, the western towards Vlandia, and the eastern towards the Empire, both markets for the hardy cattle.</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_village_B4_2']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.cattle_farm</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_village_B4_2']/@text">
        <xsl:attribute name='text'>Lindorn sits on the green hills north and west of Llyn Tywal, the dark lake. Highland cattle graze on the open grass slopes, ideal for grazing rather than farming.</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='village_B4_1']/Components/Village/@village_type">
        <xsl:attribute name='village_type'>VillageType.iron_mine</xsl:attribute>
    </xsl:template>

</xsl:stylesheet>

