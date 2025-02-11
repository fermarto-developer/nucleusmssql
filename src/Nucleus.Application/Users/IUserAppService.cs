﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Nucleus.Application.Users.Dto;
using Nucleus.Core.Users;
using Nucleus.Utilities.Collections;

namespace Nucleus.Application.Users
{
    public interface IUserAppService
    {
        Task<IPagedList<UserListOutput>> GetUsersAsync(UserListInput input);

        Task<GetUserForCreateOrUpdateOutput> GetUserForCreateOrUpdateAsync(Guid id);

        Task<IdentityResult> AddUserAsync(CreateOrUpdateUserInput input);

        Task<IdentityResult> EditUserAsync(CreateOrUpdateUserInput input);
        
        Task<IdentityResult> RemoveUserAsync(Guid id);

        Task GrantMemberRoleToUserAsync(string email);
    }
}