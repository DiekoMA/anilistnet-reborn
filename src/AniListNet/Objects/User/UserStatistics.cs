using AniListNet.Helpers;

namespace AniListNet.Objects;

public class UserStatisticsTypes
{
    [GqlSelection("anime")]
    public UserStatistics Anime { get; private set; }
    [GqlSelection("manga")]
    public UserStatistics Manga { get; private set; }
}

public class UserStatistics
{
    [GqlSelection("chaptersRead")]
    public int ChaptersRead { get; private set; }

    [GqlSelection("count")]
    public int Count { get; private set; }
    
    [GqlSelection("episodesWatched")]
    public int EpisodesWatched { get; private set; }
    
    [GqlSelection("volumesRead")]
    public float VolumesRead { get; private set; }
    
    [GqlSelection("meanScore")]
    public float MeanScore { get; private set; }
    
    [GqlSelection("minutesWatched")]
    public int MinutesWatched { get; private set; }
    
    [GqlSelection("standardDeviation")]
    public float StandardDeviation { get; private set; }
    
}