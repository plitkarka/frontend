﻿using Plitkarka.Client.Models;
using Plitkarka.Client.Repositories;

namespace Plitkarka.Client.Interfaces;

public interface IUserClient
{
    Task<IdResponse> SetUserImage(SetUserImageRequestModel image);
    Task<StringResponse> GetImageUrlByUserId(Guid id);
    Task<PaginationResponse<UserPreview>> GetAll();
    Task<UserData> GetByIdAsync(Guid id);
}