﻿using Umbraco.Cms.Core.PropertyEditors;

#pragma warning disable 1591

namespace Limbo.Umbraco.Tables.PropertyEditors {

    /// <summary>
    /// Represents a block list property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorName, EditorView, ValueType = ValueTypes.Json, Group = "Limbo", Icon = EditorIcon)]
    public class TablesDataEditor : DataEditor {

        #region Constants

        /// <summary>
        /// Gets the alias of the <see cref="TablesDataEditor"/> property editor.
        /// </summary>
        public const string EditorAlias = "Limbo.Umbraco.Tables";

        /// <summary>
        /// Gets the name of the <see cref="TablesDataEditor"/> property editor.
        /// </summary>
        public const string EditorName = "Limbo Tables";

        /// <summary>
        /// Gets the URL of the view of the <see cref="TablesDataEditor"/> property editor.
        /// </summary>
        public const string EditorView = "/App_Plugins/Limbo.Umbraco.Tables/Views/TableEditor.html";

        /// <summary>
        /// Gets the icon of the <see cref="TablesDataEditor"/> property editor.
        /// </summary>
        public const string EditorIcon = "icon-grid color-limbo";

        #endregion

        #region Constructors

        public TablesDataEditor(IDataValueEditorFactory dataValueEditorFactory) : base(dataValueEditorFactory) { }

        #endregion

    }

}