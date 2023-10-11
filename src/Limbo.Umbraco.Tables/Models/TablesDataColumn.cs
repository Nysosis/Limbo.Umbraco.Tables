﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Limbo.Umbraco.Tables.Models {

    /// <summary>
    /// Class representing a column in a <see cref="TablesDataModel"/> value.
    /// </summary>
    public class TablesDataColumn : TablesDataObject {

        /// <summary>
        /// Gets the column index.
        /// </summary>
        [JsonIgnore]
        public int Index { get; }

        internal TablesDataColumn(int index, JObject json) : base(json) {
            Index = index;
        }

    }

}