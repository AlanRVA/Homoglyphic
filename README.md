<img src="https://github.com/AlanRVA/Homoglyphic/blob/master/logo.svg" height="75" align="left" />

# Homoglyphic

<br/>

[![NuGet](https://img.shields.io/nuget/vpre/homoglyphic.svg)](https://www.nuget.org/packages/homoglyphic/)

A .net Standard 2/C# library for working with homoglyphs (characters that look identical or similar but have different unicode values).

Homoglyphic makes it easy to find strings in a body of text which contains homoglyphs to bypass regular string matching. Useful for simplifying spam/phishing detection, content moderation and scrubbing text used for training ML models.

This project was inspired by [Homoglyph](https://github.com/codebox/homoglyph) and the list of homogylphys in this project can be [found here](https://github.com/codebox/homoglyph/tree/master/raw_data/char_codes.txt)

## Installing

    Install-Package Homoglyphic

## Usage

Homoglyphic consists of two main classes, the HomoglyphicLoader and HomoglyphicSearch.

The HomoglyphicLoader accepts the file path to a CSV file of homoglyphic character sets and returns a list of hashsets representing a set of homoglyphs.

Once you have your list of homoglyphs, you can then use it to create an instance of the HomoglyphSearch class which has a single function: Search. The Search function will accept a string or list of strings and return a SearchResult ojbect for each occurance of a search string found in the string being searched.

```cs
var sets = HomoglyphLoader.LoadSets("homoglyphs.csv");
var search = new HomoglyphSearch(sets);

var result = search.Search("Th1s Is A Test", new List<string>() { "This", "Test" });
```