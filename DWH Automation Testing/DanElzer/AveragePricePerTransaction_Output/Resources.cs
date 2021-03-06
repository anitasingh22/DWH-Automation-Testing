﻿// <auto-generated />
namespace DWH_Automation_Testing.DanElzer.AveragePricePerTransaction_Output
{
    using global::System;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Resources;
    using global::System.Globalization;
    using global::System.ComponentModel;
    using global::System.CodeDom.Compiler;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources
    {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    ResourceManager temp = new ResourceManager("DWH_Automation_Testing.DanElzer.AveragePricePerTransaction_Output.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-16&quot;?&gt;&lt;TestManifest failOnServerPublishFailureExpression=&quot;False&quot; testSuiteId=&quot;5f8cbcf1-fbf3-4dbb-a5ba-9a5c63b60082&quot; testSuiteName=&quot;Average Price Per Transaction&quot; testGroupId=&quot;c4b3499a-b08a-4ee8-9f96-879cfcdba79e&quot; testGroupName=&quot;Average Price Per Transaction&quot; isSingleGroupMode=&quot;True&quot; publishUrl=&quot;https://test-api.sentryone.com&quot; publishUserName=&quot;asingh@barfoot.co.nz&quot; publishorganizationIdentifier=&quot;346&quot; accessToken=&quot;OcjV3EfxP3aWHJten0vq8y1hlAFEIPCqVPq0m7FDq5aQWcKm0kaYv/Nwmewb18l [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestManifest_AveragePricePerTransaction_c4b3499ab08a4ee89f96879cfcdba79e
        {
            get
            {
                return ResourceManager.GetString("TestManifest_AveragePricePerTransaction_c4b3499ab08a4ee89f96879cfcdba79e", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // DAX Query
        ///EVALUATE
        ///  ROW(
        ///    &quot;Average_Cleared_Sale_Price_of_Listings&quot;, &apos;Measure&apos;[Average Cleared Sale Price of Listings]
        ///  )
        ///.
        /// </summary>
        internal static string TestResource_ActualQuery_1bada2b501c74981a85d71ad1e7e511e
        {
            get
            {
                return ResourceManager.GetString("TestResource_ActualQuery_1bada2b501c74981a85d71ad1e7e511e", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // DAX Query
        ///EVALUATE
        ///  ROW(
        ///    &quot;Average_Cleared_Sale_price_of_Sales&quot;, &apos;Measure&apos;[Average Cleared Sale price of Sales]
        ///  )
        ///
        ///
        ///// DAX Query
        ///EVALUATE
        ///  ROW(
        ///    &quot;Average_Cleared_Sale_price_of_Sales&quot;, &apos;Measure&apos;[Average Cleared Sale price of Sales]
        ///  )
        ///
        ///
        ///// DAX Query
        ///EVALUATE
        ///  ROW(
        ///    &quot;Average_Cleared_Sale_price_of_Sales&quot;, &apos;Measure&apos;[Average Cleared Sale price of Sales]
        ///  )
        ///.
        /// </summary>
        internal static string TestResource_ActualQuery_331e0ec8b196448e92036adeb42a9918
        {
            get
            {
                return ResourceManager.GetString("TestResource_ActualQuery_331e0ec8b196448e92036adeb42a9918", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // DAX Query
        ///DEFINE VAR __DS0FilterTable = 
        ///  TREATAS({&quot;2020-2021&quot;}, &apos;Date&apos;[Financial Year (Calendar)])
        ///
        ///EVALUATE
        ///  TOPN(
        ///    501,
        ///    SUMMARIZECOLUMNS(
        ///      &apos;Date&apos;[Financial Year (Calendar)],
        ///      __DS0FilterTable,
        ///      &quot;Average_Cleared_Sale_Price_of_Listings_and_Sales_FYTD&quot;, &apos;Measure&apos;[Average Cleared Sale Price of Listings and Sales FYTD]
        ///    ),
        ///    &apos;Date&apos;[Financial Year (Calendar)],
        ///    1
        ///  )
        ///
        ///ORDER BY
        ///  &apos;Date&apos;[Financial Year (Calendar)]
        ///.
        /// </summary>
        internal static string TestResource_ActualQuery_666caf35e0574aae851f7404b5fc732d
        {
            get
            {
                return ResourceManager.GetString("TestResource_ActualQuery_666caf35e0574aae851f7404b5fc732d", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // DAX Query
        ///DEFINE
        ///  VAR __DS0FilterTable = 
        ///    TREATAS({&quot;January&quot;}, &apos;Date&apos;[Calendar Month Name])
        ///
        ///  VAR __DS0FilterTable2 = 
        ///    FILTER(KEEPFILTERS(VALUES(&apos;Date&apos;[Calendar Year])), &apos;Date&apos;[Calendar Year] = 2021)
        ///
        ///EVALUATE
        ///  TOPN(
        ///    501,
        ///    SUMMARIZECOLUMNS(
        ///      &apos;Date&apos;[Calendar Month Name],
        ///      &apos;Date&apos;[Financial Month Number],
        ///      &apos;Date&apos;[Calendar Year],
        ///      __DS0FilterTable,
        ///      __DS0FilterTable2,
        ///      &quot;Average_Cleared_Sale_Price_of_Listings_and_Sales_Rolling_12_Months&quot;, &apos;Measu [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestResource_ActualQuery_8607805810ce417facf21fe91474849b
        {
            get
            {
                return ResourceManager.GetString("TestResource_ActualQuery_8607805810ce417facf21fe91474849b", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // DAX Query
        ///DEFINE VAR __DS0FilterTable = 
        ///  FILTER(
        ///    KEEPFILTERS(VALUES(&apos;Listing&apos;[Listing Number])),
        ///    NOT(ISBLANK(&apos;Listing&apos;[Listing Number]))
        ///  )
        ///
        ///EVALUATE
        ///  SUMMARIZECOLUMNS(
        ///    __DS0FilterTable,
        ///    &quot;Count_of_Listings_for_Listing_Branch&quot;, IGNORE(&apos;Measure&apos;[Count of Listings for Listing Branch])
        ///  )
        ///.
        /// </summary>
        internal static string TestResource_ActualQuery_8f6a9e0d01b0452ca665fd104b9b995c
        {
            get
            {
                return ResourceManager.GetString("TestResource_ActualQuery_8f6a9e0d01b0452ca665fd104b9b995c", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // DAX Query
        ///DEFINE VAR __DS0FilterTable = 
        ///  TREATAS({&quot;2020-2021&quot;}, &apos;Date&apos;[Financial Year (Calendar)])
        ///
        ///EVALUATE
        ///  TOPN(
        ///    501,
        ///    SUMMARIZECOLUMNS(
        ///      &apos;Date&apos;[Financial Year (Calendar)],
        ///      __DS0FilterTable,
        ///      &quot;Average_Cleared_Sale_Price_of_Listings_FYTD&quot;, &apos;Measure&apos;[Average Cleared Sale Price of Listings FYTD]
        ///    ),
        ///    &apos;Date&apos;[Financial Year (Calendar)],
        ///    1
        ///  )
        ///
        ///ORDER BY
        ///  &apos;Date&apos;[Financial Year (Calendar)]
        ///.
        /// </summary>
        internal static string TestResource_ActualQuery_a0cb671b2eea488c9947978db3d4c573
        {
            get
            {
                return ResourceManager.GetString("TestResource_ActualQuery_a0cb671b2eea488c9947978db3d4c573", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // DAX Query
        ///DEFINE VAR __DS0FilterTable = 
        ///  FILTER(
        ///    KEEPFILTERS(VALUES(&apos;Listing&apos;[Listing Number])),
        ///    NOT(ISBLANK(&apos;Listing&apos;[Listing Number]))
        ///  )
        ///
        ///EVALUATE
        ///  SUMMARIZECOLUMNS(
        ///    __DS0FilterTable,
        ///    &quot;Count_of_Listings_for_Selling_Branch&quot;, IGNORE(&apos;Measure&apos;[Count of Listings for Selling Branch])
        ///  )
        ///.
        /// </summary>
        internal static string TestResource_ActualQuery_abc74bb188fe4cedbae5523a0d2ff634
        {
            get
            {
                return ResourceManager.GetString("TestResource_ActualQuery_abc74bb188fe4cedbae5523a0d2ff634", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // DAX Query
        ///DEFINE VAR __DS0FilterTable = 
        ///  TREATAS({&quot;2019-2020&quot;}, &apos;Date&apos;[Financial Year (Calendar)])
        ///
        ///EVALUATE
        ///  TOPN(
        ///    501,
        ///    SUMMARIZECOLUMNS(
        ///      &apos;Date&apos;[Financial Year (Calendar)],
        ///      __DS0FilterTable,
        ///      &quot;Average_Cleared_Sale_price_of_Sales_FYTD&quot;, &apos;Measure&apos;[Average Cleared Sale price of Sales FYTD]
        ///    ),
        ///    &apos;Date&apos;[Financial Year (Calendar)],
        ///    1
        ///  )
        ///
        ///ORDER BY
        ///  &apos;Date&apos;[Financial Year (Calendar)]
        ///.
        /// </summary>
        internal static string TestResource_ActualQuery_b6b60291bbdd48bfa06500a6900fcafb
        {
            get
            {
                return ResourceManager.GetString("TestResource_ActualQuery_b6b60291bbdd48bfa06500a6900fcafb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_ComparisonManifest_1dc20fd066444a1f8711b55213c3ab6b
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_ComparisonManifest_1dc20fd066444a1f8711b55213c3ab6b", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_ComparisonManifest_3994383f30694f0994d3935c9313e6a3
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_ComparisonManifest_3994383f30694f0994d3935c9313e6a3", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_ComparisonManifest_85c9819e84a54108b2b97421b99a794e
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_ComparisonManifest_85c9819e84a54108b2b97421b99a794e", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_ComparisonManifest_b1cd0ce1fb9540d38d3da9c5a4c4c314
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_ComparisonManifest_b1cd0ce1fb9540d38d3da9c5a4c4c314", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_ComparisonManifest_b9e65668f0e64c71b3ea72ea608f4784
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_ComparisonManifest_b9e65668f0e64c71b3ea72ea608f4784", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_ComparisonManifest_d380419f4da6454584412b1a59a2b7af
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_ComparisonManifest_d380419f4da6454584412b1a59a2b7af", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_ComparisonManifest_dda7335f0347400a83e1da204a6fbfea
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_ComparisonManifest_dda7335f0347400a83e1da204a6fbfea", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_ComparisonManifest_fe8fceb5e098450f8089e3b909ceb12a
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_ComparisonManifest_fe8fceb5e098450f8089e3b909ceb12a", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_DWHProd_c2a749ae94fd4b38a26c8ca0efb4360b
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_DWHProd_c2a749ae94fd4b38a26c8ca0efb4360b", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to with cte as
        ///(
        ///Select
        ///	s.[Sales Number],
        ///	Avg(fc.[Sale Price]) as ave
        ///from viewFactSales fc
        ///inner join viewSales s on fc.DIM_SALES_KEY=s.DIM_SALES_KEY
        ///inner join viewFactCommission c on s.DIM_SALES_KEY = c.DIM_SALES_KEY
        ///	and c.DIM_DATE_KEY = fc.DIM_DATE_FINALISED_KEY
        ///	and c.DIM_LISTING_KEY = fc.DIM_LISTING_KEY
        ///where s.[Is Sales Cleared]=1
        ///and c.[Commission Type Code]=&apos;L&apos;
        ///and c.DIM_DATE_KEY between &apos;20200401&apos; and &apos;20210331&apos;
        ///group by s.[Sales Number]
        ///)
        ///select AVG (ave) Average_Cleared_Sale_Price [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestResource_ExpectedQuery_17a787d21221438e889efd84b933c2a5
        {
            get
            {
                return ResourceManager.GetString("TestResource_ExpectedQuery_17a787d21221438e889efd84b933c2a5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to with cte as
        ///(
        ///Select
        ///	s.[Sales Number],
        ///	Avg(fc.[Sale Price]) as ave
        ///from viewFactSales fc
        ///inner join viewSales s on fc.DIM_SALES_KEY=s.DIM_SALES_KEY
        ///inner join viewFactCommission c on s.DIM_SALES_KEY = c.DIM_SALES_KEY
        ///	and c.DIM_DATE_KEY = fc.DIM_DATE_FINALISED_KEY
        ///	and c.DIM_LISTING_KEY = fc.DIM_LISTING_KEY
        ///where s.[Is Sales Cleared]=1
        ///AND c.[Commission Type Code] IN (&apos;L&apos;,&apos;S&apos;)
        ///and c.DIM_DATE_KEY between &apos;20200401&apos; and &apos;20210331&apos;
        ///group by s.[Sales Number]
        ///)
        ///select AVG (ave) Average_Cleared_S [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestResource_ExpectedQuery_2ade3d37322444eda2924a6290c32b85
        {
            get
            {
                return ResourceManager.GetString("TestResource_ExpectedQuery_2ade3d37322444eda2924a6290c32b85", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to with cte as
        ///(
        ///Select
        ///	s.[Sales Number],
        ///	Avg(fc.[Sale Price]) as ave
        ///from viewFactSales fc
        ///inner join viewSales s on fc.DIM_SALES_KEY=s.DIM_SALES_KEY
        ///inner join viewFactCommission c on s.DIM_SALES_KEY = c.DIM_SALES_KEY
        ///	and c.DIM_DATE_KEY = fc.DIM_DATE_FINALISED_KEY
        ///	and c.DIM_LISTING_KEY = fc.DIM_LISTING_KEY
        ///where s.[Is Sales Cleared]=1
        ///and c.[Commission Type Code]=&apos;S&apos;
        ///and c.DIM_DATE_KEY between &apos;20190401&apos; and &apos;20200331&apos;
        ///group by s.[Sales Number]
        ///)
        ///select AVG (ave) Average_Cleared_Sale_Price [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestResource_ExpectedQuery_42602edcdfa4451fb89fcf1e90d9658d
        {
            get
            {
                return ResourceManager.GetString("TestResource_ExpectedQuery_42602edcdfa4451fb89fcf1e90d9658d", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///with cte as
        ///(
        ///Select
        ///	s.[Sales Number],
        ///	Avg(fc.[Sale Price]) as ave,l.[Listing Number]
        ///from viewFactSales fc
        ///inner join viewSales s on fc.DIM_SALES_KEY=s.DIM_SALES_KEY
        ///inner join viewFactCommission c on s.DIM_SALES_KEY = c.DIM_SALES_KEY
        ///	and c.DIM_DATE_KEY = fc.DIM_DATE_FINALISED_KEY
        ///	and c.DIM_LISTING_KEY = fc.DIM_LISTING_KEY
        ///inner join viewListing l
        ///	on fc.DIM_LISTING_KEY=l.DIM_LISTING_KEY
        ///where s.[Is Sales Cleared]=1
        ///and c.[Commission Type Code] in (&apos;s&apos;)
        ///--and c.DIM_DATE_KEY between &apos;201 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestResource_ExpectedQuery_931fda72462049b08e1ca974dcc30e26
        {
            get
            {
                return ResourceManager.GetString("TestResource_ExpectedQuery_931fda72462049b08e1ca974dcc30e26", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///with cte as
        ///(
        ///Select
        ///	s.[Sales Number],
        ///	Avg(fc.[Sale Price]) as ave,l.[Listing Number]
        ///from viewFactSales fc
        ///inner join viewSales s on fc.DIM_SALES_KEY=s.DIM_SALES_KEY
        ///inner join viewFactCommission c on s.DIM_SALES_KEY = c.DIM_SALES_KEY
        ///	and c.DIM_DATE_KEY = fc.DIM_DATE_FINALISED_KEY
        ///	and c.DIM_LISTING_KEY = fc.DIM_LISTING_KEY
        ///inner join viewListing l
        ///	on fc.DIM_LISTING_KEY=l.DIM_LISTING_KEY
        ///where s.[Is Sales Cleared]=1
        ///and c.[Commission Type Code] in (&apos;L&apos;)
        ///--and c.DIM_DATE_KEY between &apos;201 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestResource_ExpectedQuery_a0ba92be8bc24f5292e0aac023152f83
        {
            get
            {
                return ResourceManager.GetString("TestResource_ExpectedQuery_a0ba92be8bc24f5292e0aac023152f83", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to with cte as
        ///(
        ///Select
        ///	s.[Sales Number],
        ///	Avg(fc.[Sale Price]) as ave
        ///from viewFactSales fc
        ///inner join viewSales s on fc.DIM_SALES_KEY=s.DIM_SALES_KEY
        ///inner join viewFactCommission c on s.DIM_SALES_KEY = c.DIM_SALES_KEY
        ///	and c.DIM_DATE_KEY = fc.DIM_DATE_FINALISED_KEY
        ///	and c.DIM_LISTING_KEY = fc.DIM_LISTING_KEY
        ///where s.[Is Sales Cleared]=1
        ///AND c.[Commission Type Code] IN (&apos;L&apos;,&apos;S&apos;)
        ///and c.DIM_DATE_KEY between &apos;20200201&apos; and &apos;20210131&apos;
        ///group by s.[Sales Number]
        ///)
        ///select AVG (ave) Average_Cleared_S [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestResource_ExpectedQuery_bfab3ea49a8d4fa7bd74384886434b81
        {
            get
            {
                return ResourceManager.GetString("TestResource_ExpectedQuery_bfab3ea49a8d4fa7bd74384886434b81", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to with cte as
        ///(
        ///Select
        ///	s.[Sales Number],
        ///	Avg(fc.[Sale Price]) as ave
        ///from viewFactSales fc
        ///inner join viewSales s on fc.DIM_SALES_KEY=s.DIM_SALES_KEY
        ///inner join viewFactCommission c on s.DIM_SALES_KEY = c.DIM_SALES_KEY
        ///	and c.DIM_DATE_KEY = fc.DIM_DATE_FINALISED_KEY
        ///	and c.DIM_LISTING_KEY = fc.DIM_LISTING_KEY
        ///where s.[Is Sales Cleared]=1
        ///and c.[Commission Type Code]=&apos;L&apos;
        ///group by s.[Sales Number]
        ///)
        ///select AVG (ave)  Average_Cleared_Sale_price_of_Listing
        ///FROM cte
        /// .
        /// </summary>
        internal static string TestResource_ExpectedQuery_d962058ca5454d04abeb79507d3d771f
        {
            get
            {
                return ResourceManager.GetString("TestResource_ExpectedQuery_d962058ca5454d04abeb79507d3d771f", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to with cte as
        ///(
        ///Select
        ///	s.[Sales Number],
        ///	Avg(fc.[Sale Price]) as ave
        ///from viewFactSales fc
        ///inner join viewSales s on fc.DIM_SALES_KEY=s.DIM_SALES_KEY
        ///inner join viewFactCommission c on s.DIM_SALES_KEY = c.DIM_SALES_KEY
        ///	and c.DIM_DATE_KEY = fc.DIM_DATE_FINALISED_KEY
        ///	and c.DIM_LISTING_KEY = fc.DIM_LISTING_KEY
        ///where s.[Is Sales Cleared]=1
        ///and c.[Commission Type Code]=&apos;S&apos;
        ///group by s.[Sales Number]
        ///)
        ///select AVG (ave)  Average_Cleared_Sale_price_of_Sales
        ///FROM cte
        /// .
        /// </summary>
        internal static string TestResource_ExpectedQuery_dcb51eca5b664b39982881f5f1e08927
        {
            get
            {
                return ResourceManager.GetString("TestResource_ExpectedQuery_dcb51eca5b664b39982881f5f1e08927", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_SSASMatrixProduction_b89de6cae6604205b75e0566246db3fc
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_SSASMatrixProduction_b89de6cae6604205b75e0566246db3fc", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}

