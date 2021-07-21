using Microsoft.AspNetCore.Identity;
using UBSI_Ops.server.Auth;
using UBSI_Ops.server.Core.Files;
using UBSI_Ops.server.Data;
using UBSI_Ops.server.Entities.Identity;

namespace UBSI_Ops.server.Services.Services
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
