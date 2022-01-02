﻿
using System.Reflection;
using WebExpress.WebAttribute;
using WebExpress.UI.WebControl;
using WebExpress.Uri;
using WebExpress.WebApp.WebPage;
using WebExpress.WebResource;

namespace ViLa.WebPage
{
    [ID("Help")]
    [Title("vila:vila.help.label")]
    [Segment("help", "vila:vila.help.label")]
    [Path("/")]
    [Module("ViLa")]
    [Context("general")]
    [Context("help")]
    public sealed class PageHelp : PageWebApp
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageHelp()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);
        }

        /// <summary>
        /// Verarbeitung
        /// </summary>
        /// <param name="context">Der Kontext zum Rendern der Seite</param>
        public override void Process(RenderContextWebApp context)
        {
            base.Process(context);

            context.VisualTree.Content.Primary.Add(new ControlImage()
            {
                Uri = context.Uri.Root.Append("assets/img/vila.svg"),
                Width = 200,
                Height = 200,
                HorizontalAlignment = TypeHorizontalAlignment.Right
            });

            var card = new ControlPanelCard();

            card.Add(new ControlText()
            {
                Text = "vila:app.label",
                Format = TypeFormatText.H3
            });

            card.Add(new ControlText()
            {
                Text = "vila:app.description",
                Format = TypeFormatText.Paragraph
            });

            card.Add(new ControlText()
            {
                Text = "vila:vila.help.privacypolicy.label",
                Format = TypeFormatText.H3
            });

            card.Add(new ControlText()
            {
                Text = "vila:vila.help.privacypolicy.description",
                Format = TypeFormatText.Paragraph
            });

            card.Add(new ControlText()
            {
                Text = "vila:vila.help.disclaimer.label",
                Format = TypeFormatText.H3
            });

            card.Add(new ControlText()
            {
                Text = "vila:vila.help.disclaimer.description",
                Format = TypeFormatText.Paragraph
            });

            card.Add(new ControlText()
            {
                Text = "vila:vila.help.about.label",
                Format = TypeFormatText.H3
            });

            card.Add(new ControlText()
            {
                Text = "vila:vila.help.version.label",
                TextColor = new PropertyColorText(TypeColorText.Primary)
            });

            card.Add(new ControlText()
            {
                Text = string.Format("{0}", Context.Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion),
                TextColor = new PropertyColorText(TypeColorText.Dark)
            });

            card.Add(new ControlText()
            {
                Text = "vila:vila.help.contact.label",
                TextColor = new PropertyColorText(TypeColorText.Primary)
            });

            card.Add(new ControlLink()
            {
                Text = string.Format("rene_schwarzer@hotmail.de"),
                Uri = new UriAbsolute()
                {
                    Scheme = UriScheme.Mailto,
                    Authority = new UriAuthority("rene_schwarzer@hotmail.de")
                },
                TextColor = new PropertyColorText(TypeColorText.Dark)
            });

            context.VisualTree.Content.Primary.Add(card);
        }
    }
}
