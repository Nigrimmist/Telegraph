using System;
using System.Collections.Generic;
using Kvyk.Telegraph;
using Kvyk.Telegraph.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new TelegraphClient();
            Account account = client.CreateAccount(
                "MyFirstAccount",     //Short name
                "I am",               //Author name
                "https://example.com" //Author link
            ).Result;
            client.AccessToken = account.AccessToken; //Your token. Save it to use your account in the future

            var nodes = new List<Node>  //Page is an array of nodes
            {
                Node.H3("Test header"),
                Node.P("Hello, World!"),
                Node.ImageFigure("https://telegra.ph/images/logo.png", "Logo"),
            };

            var page = client.CreatePage(
                "Test page", //Page title
                nodes,
                authorName: "authorname",
                authorUrl: "http://nigrimmist.com"
            ).Result;

            var url = page.Url; //Here is your page url
        }
    }
}
