<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <head>
                <title>Machine.Specifications Report - <xsl:value-of select="MSpec/generated/date" /> at <xsl:value-of select="/MSpec/generated/time" /></title>
                <style>
                    .concernHeader
                    {
                        margin-left: 2em;
                        float: left;
                        margin-top: 0;
                        margin-bottom: 0;
                    }
                    
                    .concernHeader span.concern
                    {
                        font-style: italic;
                    }
                    
                    .concernHeader span.static
                    {
                        font-weight: normal;
                        padding-left: .3em;
                        font-size: .7em;
                    }
                    
                    .assemblyHeader
                    {
                        float: left;
                        margin-top: 0;
                        margin-bottom: 0;
                        margin-right: 0;
                        margin-left: 0;
                    }
                    
                    .assemblySummary
                    {
                        vertical-align: bottom;
                        margin-left: 1em;
                        font-style: italic;
                        color: #888888;
                        position: relative;
                        top: .5em;
                    }
                    
                    .context
                    {
                        margin-bottom: 1em;
                    }
                    
                    .contextHeader
                    {
                        margin-left: 4em;
                        margin-bottom: 0;
                        float: left;
                        margin-top: .5em;
                    }
                    
                    .specificationList
                    {
                        margin-left: 4.5em;
                        margin-top: .1em;
                        margin-bottom: .1em;
                    }
                    
                    .resultsSummary
                    {
                        float: right;
                    }
                    
                    ul.specificationList li
                    {
                        padding: .2em;
                    }
                    
                    ul.specificationList li i
                    {
                        padding-right: .2em;
                    }
                    
                    ul.specificationList li.passedStatus
                    {
                        background-color: #00FF00;
                    }
                    
                    ul.specificationList li.failedStatus
                    {
                        background-color: #FF0000;
                    }
                    .footer
                    {
                        font-size: .7em;
                        text-align: right;
                    }
                    
                    .overallSummary
                    {
                        float: right;
                        margin-top: 0;
                        margin-bottom: 0;
                        padding-top: 0;
                        padding-bottom: 0;
                    }
                </style>
            </head>
            <body>
                <div class="overallSummary">
                    Passed specifications: <xsl:value-of select="count(//specification[@status = 'passed'])" />/<xsl:value-of select="count(//specification)" /> (<xsl:value-of select="ceiling(count(//specification[@status = 'passed']) div count(//specification) * 100)" />%)
                </div>
                <div>Generated on <xsl:value-of select="MSpec/generated/date" /> at <xsl:value-of select="/MSpec/generated/time" />.</div>
                <xsl:for-each select="/MSpec/assembly">
                    <xsl:sort select="@name" />
                    <hr />
                    <div>
                        <h1 class="assemblyHeader"><xsl:value-of select="@name" /></h1>
                        <span class="assemblySummary">
                            <xsl:value-of select="count(concern)" /> concern<xsl:if test="count(concern) != 1">s</xsl:if>,
                            <xsl:value-of select="count(concern/context)" /> context<xsl:if test="count(concern/context) != 1">s</xsl:if>,
                            <xsl:value-of select="count(concern/context/specification)" /> specification<xsl:if test="count(concern/context/specification) != 1">s</xsl:if>
                        </span>
                        <span class="resultsSummary">
                            Passed specifications: <xsl:value-of select="count(concern//specification[@status = 'passed'])" />/<xsl:value-of select="count(concern//specification)" /> (<xsl:value-of select="ceiling(count(concern//specification[@status = 'passed']) div count(concern//specification) * 100)" />%)
                        </span>
                        <div style="clear:both;" />
                        <div class="concern">
                            <xsl:for-each select="concern">
                                <xsl:sort select="@name" />
                                <h2 class="concernHeader"><span class="concern"><xsl:value-of select="@name" /></span> <span class="static">specifications</span></h2>
                                <span class="assemblySummary">
                                    <xsl:value-of select="count(context)" /> context<xsl:if test="count(context) != 1">s</xsl:if>,
                                    <xsl:value-of select="count(context/specification)" /> specification<xsl:if test="count(context/specification) != 1">s</xsl:if>
                                </span>
                                <div style="clear:both;" />
                                <xsl:for-each select="context" >
                                    <xsl:sort select="@name" />
                                    <div class="context">
                                        <h3 class="contextHeader"><xsl:value-of select="@name" /></h3>
                                        <span class="assemblySummary">
                                            <xsl:value-of select="count(specification)" /> specification<xsl:if test="count(specification) != 1">s</xsl:if>
                                        </span>
                                        <div style="clear:both;" />
                                        <ul class="specificationList">
                                            <xsl:for-each select="specification" >
                                                <xsl:sort select="@name" />
                                                <li>
                                                    <xsl:attribute name="class">
                                                        <xsl:value-of select="@status" />Status
                                                    </xsl:attribute>
                                                    <i>It</i>
                                                    <xsl:value-of select="@name" />
                                                </li>
                                            </xsl:for-each>
                                        </ul>
                                    </div>
                                </xsl:for-each>
                            </xsl:for-each>
                        </div>
                    </div>
                </xsl:for-each>
                <div class="footer">
                    Generated using <a href="http://github.com/machine/machine.specifications">Machine.Specifications</a>.
                </div>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>