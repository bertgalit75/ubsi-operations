using Microsoft.AspNetCore.Identity;
using Ropes.API.Auth;
using Ropes.API.Core.Files;
using Ropes.API.Data;
using Ropes.API.Entities.Identity;

namespace Ropes.API.Services.Services
{
    public class AccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly ICurrentUser _currentUser;
        private readonly TokenService _tokenService;
        private readonly OperationContext _operationContext;
        private readonly GenerateDefaultImageService _generateDefaultImageService;
        private readonly IFilesystem _fileSystem;

        public AccountService(UserManager<User> userManager,
            ICurrentUser currentUser,
            TokenService tokenService,
            GenerateDefaultImageService generateDefaultImageService,
            IFilesystem filesystem, OperationContext operationContext)
        {
            _userManager = userManager;
            _currentUser = currentUser;
            _tokenService = tokenService;
            _operationContext = operationContext;
            _generateDefaultImageService = generateDefaultImageService;
            _fileSystem = filesystem;
        }
    }
}
