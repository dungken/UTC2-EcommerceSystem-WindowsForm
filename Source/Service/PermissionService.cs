﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source.DataAcess;
using Source.Dtos.Order;
using Source.Dtos.Reponse;
using Source.Dtos.Role;

namespace Source.Service
{
    public class PermissionService
    {
        private readonly ApiClient _apiClient;
        public PermissionService()
        {
            _apiClient = new ApiClient(Utils.Config.BaseUrl);
        }
        public async Task<BaseResponse<PermissionRespone>> GetPermissions()
        {
            return await _apiClient.GetAsync<BaseResponse<PermissionRespone>>("Permission/GetAll");
        }
        public async Task<BaseResponse<PermissionWithRolesDto>> GetPermissionsWithRoles()
        {
            return await _apiClient.GetAsync<BaseResponse<PermissionWithRolesDto>>("Permission/GetAllWithRoles");
        }
        public async Task<BaseResponse<PermissionDto>> GetById(Guid permissionId)
        {
            return await _apiClient.GetAsync<BaseResponse<PermissionDto>>($"Permission/{permissionId}");
        }
        public async Task<BaseResponse<CreatePermissionDto>> CreateOrUpdatePermission(CreatePermissionDto model)
        {
            return await _apiClient.PostAsync<BaseResponse<CreatePermissionDto>>("Permission/CreateOrUpdate", model);
        }
        public async Task<bool> DeletePermission(Guid permissionId)
        {
            return await _apiClient.DeleteAsync($"Permission/Delete/{permissionId}");
        }
    }
}