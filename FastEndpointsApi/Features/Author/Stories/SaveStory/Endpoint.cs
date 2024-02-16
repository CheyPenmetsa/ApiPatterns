using FastEndpoints;

namespace Author.Stories.SaveStory
{
    internal sealed class Endpoint : Endpoint<Request, Response, Mapper>
    {
        public override void Configure()
        {
            Post("/author/savestory");
            AllowAnonymous();
        }

        public override async Task HandleAsync(Request r, CancellationToken c)
        {
            var storyEntity = Map.ToEntity(r);

            //Call methods for saving the story and do perform any busines logic.

            await SendAsync(new Response()
            {
                Message = "Story created successfully"
            });
        }
    }
}