using System;
// namespace orginizes classes
namespace LyricsNameSpace{// open namespace LyricsNameSpace
/*
Programming in C#
Assignment 1.2
Matt Ramey
5/24/2024
*/
// create a class Lyrics that will run a method that can access string variables that are lines in a song.
 public class Lyrics {// open class Lyrics
// initialize attributes
    public string Line1 {get; set;}
    public string Line2 {get; set;}
    public string Line3 {get; set;}
    public string Line4 {get; set;}
    public string Line5 {get; set;}

// method that accesses song lyrics
    public string songLyrics() {// open songLyrics()
// $" for string interpolation. This line will return each individual line of lyrics based on the element in the songs array      
      return $"{Line1}\n{Line2}\n{Line3}\n{Line4}\n{Line5}\n";
      
    }// close songLyrics()
  }// close class Lyrics
  
 //create a class that initiallizes an array of objects 
  public class TestLyrics{ // open TestLyrics
    public static void Main (string[] args) {// open main
// array initializer for song lyrics
    Lyrics[] songs = new Lyrics[]{ // open lyrics []
      new Lyrics{// lyrics for 1st song
        Line1 = "Oh, well imagine",
        Line2 ="As I'm pacing the pews in a church corridor",
        Line3 ="And I can't help but to hear",
        Line4 = "No, I can't help but to hear an exchanging of words..."
      },// close lyrics for 1st song
      
      new Lyrics{// lyrics for 2nd song
        Line1 = "Oh-oh-oh-oh-oh,",
        Line2 ="oh-oh-oh-oh,",
        Line3 ="oh-oh-oh",
        Line4 = "Caught in a bad romance..."
      },// close lyrics for 2nd song

      new Lyrics{// lyrics for 3rd song
        Line1 = "Coming out of my cage",
        Line2 ="And I've been doing just fine",
        Line3 ="Gotta gotta be down",
        Line4 = "Because I want it all"
      },// close lyrics for 3rd song

      new Lyrics{// lyrics for 4th song
        Line1 = "Now, this is a story all about how",
        Line2 ="My life got flipped-turned upside down",
        Line3 ="And I'd like to take a minute",
        Line4 = "Just sit right there",
        Line5 = "I'll tell you how I became the prince of a town called Bel-Air"
      }// close lyrics for 4th song
      
    };// close Lyrics []

// create a foreach loop that will run through the array of objects and print out each individual line of the song. Then add a line in the loop that states "test passed" to display after the song is printed.. the final Console.WriteLine is to add a space on the final "test passed" string  
    foreach (var song in songs){
      Console.WriteLine(song.songLyrics());
      Console.WriteLine("Test Passed");
      Console.WriteLine();
    }
    
      }// close main
    }// close TestLyrics
  }// close SongNameSpace
 
