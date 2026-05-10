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

    [GqlSelection("episodesWatched")]
    public int EpisodesWatched { get; private set; }
    
    [GqlSelection("count")]
    public int Count { get; private set; }
    
    
    
}