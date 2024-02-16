using FastEndpoints;
using MediumVericalSliceApi.BusinessLogic.Entities;

namespace Author.Stories.SaveStory
{
    internal sealed class Mapper : Mapper<Request, Response, StoryEntity>
    {
        public override StoryEntity ToEntity(Request r) => new()
        {
            Title = r.Title,
            Content = r.Content,
            Tags = r.Tags
        };
    }
}