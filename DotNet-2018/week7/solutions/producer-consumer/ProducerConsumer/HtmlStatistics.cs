using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace ProducerConsumer
{
    public class HtmlStatistics
    {
        private readonly string url;
        private readonly HtmlDocument htmlDocument;

        public HtmlStatistics(string html, string url)
        {
            this.url = url;
            htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            CleanDocument();
        }

        public int GetWordCount()
        {
            var bodyText = HtmlEntity.DeEntitize(htmlDocument.DocumentNode.SelectSingleNode("//body").InnerText);

            //var strings = wordSplitterRegex.Split(bodyText);
            var punctuation = bodyText.Where(char.IsPunctuation).Distinct().ToArray();
            var strings = bodyText.Split();
            var words = strings.Select(x => x.Trim(punctuation)).Where(s => !string.IsNullOrEmpty(s));
            return words.Count();
        }

        public int GetSentenceCount()
        {
            var bodyText = HtmlEntity.DeEntitize(htmlDocument.DocumentNode.SelectSingleNode("//body").InnerText);

            var strings = bodyText.Split('.', '!', '?');

            return strings.Length;
        }

        public IReadOnlyCollection<string> GetImageLinks()
        {
            return htmlDocument.DocumentNode.Descendants()
                .Where(n => n.Name == "img")
                .Select(n => n.GetAttributeValue("src", null))
                .Where(n => !string.IsNullOrEmpty(n))
                .Select(ToAbsoluteUrl)
                .ToList();
        }

        public IReadOnlyCollection<string> GetLinks()
        {
            return htmlDocument.DocumentNode.Descendants()
                .Where(n => n.Name == "a")
                .Select(n => n.GetAttributeValue("href", null))
                .Where(n => !string.IsNullOrEmpty(n))
                .Select(ToAbsoluteUrl)
                .ToList();
        }

        private string ToAbsoluteUrl(string path)
        {
            var uri = new Uri(url, UriKind.Absolute);

            uri = new Uri(uri, path);

            return uri.ToString();
        }

        private void CleanDocument()
        {
            htmlDocument.DocumentNode.Descendants()
                .Where(n => n.Name == "script" || n.Name == "style")
                .ToList()
                .ForEach(n => n.Remove());
        }
    }
}