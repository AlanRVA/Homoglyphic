<img src="http://localhost/homoglyphic/logo.svg" height="75" />

# Homoglyphic
A .net Standard 2/C# library for normalizing homoglyphs (characters that look identical or similar but have different unicode values) to their base look-alike characters.

Homoglyphic makes it easy to convert unicode characters to the most common characters they resemble. Useful for simplifying spam/phishing detection, content moderation and scrubbing text used for training ML models.

The list of homogylphys in this project was sourced from https://github.com/codebox/homoglyph/tree/master/raw_data/char_codes.txt

## Usage

Homoglyphic consists of two main classes, the HomoglyphicLoader and HomoglyphicReplacer.

The HomoglyphicLoader accepts the file path to a CSV file of homoglyphic character sets and returns an array of HomogylphPair ojbects, one for each look-alike character.

The HomogylphPair class contains the base character and the UnicodePoint of a character which resembles the base character.

Once you have your array of HomogylphPairs, you can then use it to create an instance of the HomoglyphicReplacer class which has a single function: Replace, which replaces any look-alike characters in the input string with their base character and returns the normalized version of that string.

```cs
var pairs = HomoglyphLoader.LoadPairs("homoglyphs.csv");
var replacer = new HomoglyphReplacer(pairs);

var normalizedString = replacer.Replace("⟙hiƽ ƽtring contaｉnƽ һomoglyphƽ");
```