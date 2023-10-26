// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    /// <summary> Query result. </summary>
    public partial class ResourceQueryResult
    {
        /// <summary> Initializes a new instance of ResourceQueryResult. </summary>
        /// <param name="totalRecords"> Number of total records matching the query. </param>
        /// <param name="count"> Number of records returned in the current response. In the case of paging, this is the number of records in the current page. </param>
        /// <param name="resultTruncated"> Indicates whether the query results are truncated. </param>
        /// <param name="data"> Query output in JObject array or Table format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        internal ResourceQueryResult(long totalRecords, long count, ResultTruncated resultTruncated, BinaryData data)
        {
            Argument.AssertNotNull(data, nameof(data));

            TotalRecords = totalRecords;
            Count = count;
            ResultTruncated = resultTruncated;
            Data = data;
            Facets = new ChangeTrackingList<Facet>();
        }

        /// <summary> Initializes a new instance of ResourceQueryResult. </summary>
        /// <param name="totalRecords"> Number of total records matching the query. </param>
        /// <param name="count"> Number of records returned in the current response. In the case of paging, this is the number of records in the current page. </param>
        /// <param name="resultTruncated"> Indicates whether the query results are truncated. </param>
        /// <param name="skipToken"> When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data. </param>
        /// <param name="data"> Query output in JObject array or Table format. </param>
        /// <param name="facets">
        /// Query facets.
        /// Please note <see cref="Facet"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FacetError"/> and <see cref="FacetResult"/>.
        /// </param>
        internal ResourceQueryResult(long totalRecords, long count, ResultTruncated resultTruncated, string skipToken, BinaryData data, IReadOnlyList<Facet> facets)
        {
            TotalRecords = totalRecords;
            Count = count;
            ResultTruncated = resultTruncated;
            SkipToken = skipToken;
            Data = data;
            Facets = facets;
        }

        /// <summary> Number of total records matching the query. </summary>
        public long TotalRecords { get; }
        /// <summary> Number of records returned in the current response. In the case of paging, this is the number of records in the current page. </summary>
        public long Count { get; }
        /// <summary> Indicates whether the query results are truncated. </summary>
        public ResultTruncated ResultTruncated { get; }
        /// <summary> When present, the value can be passed to a subsequent query call (together with the same query and scopes used in the current request) to retrieve the next page of data. </summary>
        public string SkipToken { get; }
        /// <summary>
        /// Query output in JObject array or Table format.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Data { get; }
        /// <summary>
        /// Query facets.
        /// Please note <see cref="Facet"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FacetError"/> and <see cref="FacetResult"/>.
        /// </summary>
        public IReadOnlyList<Facet> Facets { get; }
    }
}
