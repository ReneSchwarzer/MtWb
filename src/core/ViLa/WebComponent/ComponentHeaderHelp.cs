﻿using ViLa.WebPage;
using WebExpress.Attribute;
using WebExpress.Html;
using WebExpress.UI.Attribute;
using WebExpress.UI.WebComponent;
using WebExpress.UI.WebControl;
using WebExpress.Uri;
using WebExpress.WebApp.WebComponent;
using WebExpress.WebPage;

namespace ViLa.WebComponent
{
    [Section(Section.AppHelpPrimary)]
    [Application("ViLa")]
    public sealed class ComponentHeaderHelp : ControlDropdownItemLink, IComponent
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public ComponentHeaderHelp()
            : base()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public void Initialization(IComponentContext context)
        {
            TextColor = new PropertyColorText(TypeColorText.Dark);
            Text = "vila:vila.help.label";
            Icon = new PropertyIcon(TypeIcon.InfoCircle);
            Uri = new UriResource(context.Module.ContextPath, "help");
        }

        /// <summary>
        /// In HTML konvertieren
        /// </summary>
        /// <param name="context">Der Kontext, indem das Steuerelement dargestellt wird</param>
        /// <returns>Das Control als HTML</returns>
        public override IHtmlNode Render(RenderContext context)
        {
            Active = context.Page is IPageHelp ? TypeActive.Active : TypeActive.None;

            return base.Render(context);
        }

    }
}