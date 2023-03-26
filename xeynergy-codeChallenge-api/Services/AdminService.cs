using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xeynergy_codeChallenge_api.Dtos;
using xeynergy_codeChallenge_api.Entities;
using xeynergy_codeChallenge_api.Models;
using xeynergy_codeChallenge_api.Repository;

namespace xeynergy_codeChallenge_api.Services
{
    public class AdminService : IAdminService
    {        
        // Create a field to store the mapper object
        private readonly IMapper _mapper;
        private readonly IAdminRepository _adminRepository;
        public AdminService(IAdminRepository adminRepository,IMapper mapper)
        {            
            _mapper = mapper;
            _adminRepository = adminRepository;
        }
        public async Task<bool> DeleteAdmin(Guid id) => await _adminRepository.DeleteAdmin(id);
        public async Task<AdminDto> GetAdminByID(Guid adminId)
        {
            var admin = await _adminRepository.GetAdminByID(adminId);
            return _mapper.Map<AdminDto>(admin);
        }
        public async Task<IEnumerable<AdminDto>> GetAdmins()
        {
            var admins = await _adminRepository.GetAdmins();
            return _mapper.Map<IEnumerable<AdminDto>>(admins);
        }
        public async Task<AdminDto> InsertAdmin(AdminModel adminModel) 
        {
            var admin = _mapper.Map<Admin>(adminModel);
            var insertedAdmin = await _adminRepository.InsertAdmin(admin);
            return _mapper.Map<AdminDto>(insertedAdmin);
        }
        public async Task<AdminDto> UpdateAdmin(AdminModel adminModel)
        {
            var admin = _mapper.Map<Admin>(adminModel);
            var insertedAdmin = await _adminRepository.UpdateAdmin(admin);
            return _mapper.Map<AdminDto>(insertedAdmin);
        }
    }
}
