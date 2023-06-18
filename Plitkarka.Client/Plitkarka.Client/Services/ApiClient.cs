﻿using Plitkarka.Client.Interfaces;

namespace Plitkarka.Client.Services;

public class ApiClient: IApiClient
{
    public IUserClient UserClient { get; }
    public IAuthClient AuthClient { get; }
    public IPostClient PostClient { get; }
    public ICommentClient CommentClient { get; }
    public IResetPasswordClient ResetPasswordClient { get; }
    public ISubscriptionClient SubscriptionClient { get; }

    public ApiClient(IUserClient userClient,
        IAuthClient authClient,
        IPostClient postClient,
        ICommentClient commentClient,
        IResetPasswordClient resetPasswordClient,
        ISubscriptionClient subscriptionClient)
    {
        UserClient = userClient;
        AuthClient = authClient;
        PostClient = postClient;
        CommentClient = commentClient;
        ResetPasswordClient = resetPasswordClient;
        SubscriptionClient = subscriptionClient;
    }   
}
