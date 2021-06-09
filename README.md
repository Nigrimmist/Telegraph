# Kvyk.Telegraph
Simple to use api-client for [Telegra.ph](https://telegra.ph).

C# .NET 5.0

## Installation
Install last varsion
```
Install-Package Kvyk.Telegraph
```
|Package Name|Release|Version|
|:---:|:---:|---:|
|`Kvyk.Telegraph`|[NuGet]()|1.0.0|

## How to use

You can find all documentation on [Wiki](https://github.com/MarkoKvyk/Telegraph/wiki)

### Quick start

Add `using` to the top of your file
```C#
using Kvyk.Telegraph;
using Kvyk.Telegraph.Models;
```
Let's create first account
```C#
var client = new TelegraphClient();
Account account = await client.CreateAccount(
  "MyFirstAccount",     //Short name
  "I am",               //Author name
  "https://example.com" //Author link
);
client.Token = account.AccessToken; //Your token. Save it to use your account in the future
```
Now we can create your first page
```C#
var nodes = new List<Node>  //Page is an array of nodes
{
  new Node()
  {
    Tag = TagEnum.H3,
    Children = new List<Node>()
    {
      new Node()
      {
        Value = "Test header"
      }
    }
  },
  new Node()
  {
    Tag = TagEnum.P,
    Children = new List<Node>()
    {
      new Node()
      {
        Value = "Hello, World!"
      }
    }
  },
  new Node()
  {
    Tag = TagEnum.Img,
    Artibutes = new TagAttributes()
    {
      Src = "https://telegra.ph/images/logo.png"
    }
  }
};

var page = await client.CreatePage(
  "Test page", //Page title
  nodes
);

var url = page.Url; //Here is your page url
```

The example of the created page: https://telegra.ph/Test-page-06-07-22

## How to help?

This is my first NuGet package, so I'm waiting for a feedback!

Please, tell me about any things I've missed or skiped, any features about code and comments, project description and design of repo. I will be happy to get any feedback.

Use issues or just send me email: `kvykmarko@gmail.com`
