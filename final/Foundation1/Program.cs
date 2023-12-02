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
                _title = "Stand Forever | Lawrence E. Corbridge | 2019",
                _author = "BYU Speeches",
                _lengthInSeconds = 1620
            }
        };

        // Add comments to each video
        _videos[0].AddComment("@loribickle5252", "11 months ago", "I cherish this album and play it every Christmas since it was released. It fills my heart.");
        _videos[0].AddComment("@neilreynolds6899", "3 year ago", "This entire album is Priceless!! Beautiful.");
        _videos[0].AddComment("@kevinwiley9696", "3 months ago", "LOVE, LOVE, LOVE this album!!!!!");

        _videos[1].AddComment("@Mori", "3 weeks ago", "Hopefully Netflix nails it this time. I believe they will.");
        _videos[1].AddComment("@vangel0sgarg0yle", "1 day ago", "This actually looks promising! Hopefully the redemption arc begins. T^T");
        _videos[1].AddComment("@HelloFutureMe", "3 weeks ago", "The redemption arc hopefully begins.");

        _videos[2].AddComment("@clownymcgiggles6757", "11 months ago", "Every member needs to hear this talk.");
        _videos[2].AddComment("@JuanSuttonUtah", "3 years ago", "This has to be one of the top ten talks of all time. Why anyone would thumbs down this is beyond me.");
        _videos[2].AddComment("@wallaceladmers3521", "1 year ago", "Best talk ever. May we all fill that gap between our beliefs and the truth.");
        _videos[2].AddComment("@lloydlee2176", "4 years ago", "This is one of the most beautiful talks I’ve ever heard. Thank you.");

        // Display information about each video
        foreach (Video video in _videos)
        {
            video.DisplayVideoInfo();
        }
    }
}