using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create _videos
        Console.Clear();
        Console.WriteLine();
        List<Video> _videos = new List<Video>
        {
            new Video
            {
                _title = "Aspenglow",
                _author = "John Denver",
                _lengthInSeconds = 140
            },
            new Video
            {
                _title = "Avatar: The Last Airbender | Official Teaser | Netflix",
                _author = "Netflix",
                _lengthInSeconds = 112
            },
            new Video
            {
                _title = "Remembering the Life of President M. Russell Ballard",
                _author = "Church Newsroom",
                _lengthInSeconds = 370
            }
        };

        // Add comments to each video
        _videos[0].AddComment("@loribickle5252", "I cherish this album and play it every Christmas since it was released. It fills my heart.");
        _videos[0].AddComment("@jamiejackson3903", "Truly one of the great modern holiday songs. This track matches the inherent beauty of some of the great and classic Christmas carols. Thank you for this amazing gift, Mr. Denver.");

        _videos[1].AddComment("@Mori", "Hopefully Netflix nails it this time. I believe they will.");
        _videos[1].AddComment("@vantoannguyen7730", "I used to dream for the cinematic version while watching whole series for many times so many years ago. It's incredible!");

        _videos[2].AddComment("@edwardhegemann5951", "President Ballard did so much good behind the scenes that most people will never know about. He ministered to my father who isn’t a member of the church. He wrote him a kind letter. I’ll forever be grateful for his Christ-like love and service.");
        _videos[2].AddComment("@ScamwatchDallin", "I was in the missionary choir in October 2022's general conference. It was a landmark moment for me when he thanked us for singing Faith in Every Footstep. I'll miss him dearly, but glad he won't have to miss his dear wife anymore.");
        _videos[2].AddComment("@linksmusic2060", "Thank you President Ballard, for everything!!!");

        // Display information about each video
        foreach (Video video in _videos)
        {
            video.DisplayVideoInfo();
        }
    }
}