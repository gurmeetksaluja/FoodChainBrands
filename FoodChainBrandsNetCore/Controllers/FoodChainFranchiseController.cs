﻿using FoodChainBrands.Core;
using FoodChainBrands.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodChainBrandsNetCore.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FoodChainFranchiseController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FoodChainFranchiseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Route("FoodChainFranchises")]
        [HttpGet]
        public async Task<IActionResult> GetFoodChainFranchises(int id)
        {
            //var i = 2 / 0;
            var franchise = await _unitOfWork.FoodChainFranchises.GetMultipleDataByConditionAsync(new { @FoodChainId = id, @IsActive = true, @IsDeleted = false });
            return Ok(franchise);
        }


        [Route("FoodChainFranchiseDetail")]
        [HttpGet]
        public async Task<IActionResult> GetFoodChainFranchiseDetail(int id)
        {
            var franchise = await _unitOfWork.FoodChainFranchises.GetDataByIdAsync(new { @Id = id, @IsActive = true, @IsDeleted = false });
            return Ok(franchise);
        }

        [Route("AddUpdateFoodChainFranchises")]
        [HttpPost]
        public async Task<IActionResult> AddUpdateFoodChainFranchises(IEnumerable<FoodChainFranchiseModel> model)
        {
            if (model.Any())
            {
                var franchisesForAdd = model.Where(x => x.Id == 0).ToList();
                var franchiseForUpdate = model.Except(franchisesForAdd);
                if (franchisesForAdd.Any())
                {
                    var franchises = franchisesForAdd.Select(x => new FoodChainFranchises
                    {
                        Address = x.Address,
                        City = x.City,
                        Country = x.Country,
                        FoodChainId = x.FoodChainId,
                        PinCode = x.PinCode,
                        State = x.State
                    }).ToList();

                    return StatusCode(201, await _unitOfWork.FoodChainFranchises.AddAsync(franchises));
                }
                if (franchiseForUpdate.Any())
                {
                    foreach (var item in franchiseForUpdate)
                    {
                        var foodChainFranchiseEntity = await _unitOfWork.FoodChainFranchises.GetDataByIdAsync(new { @Id = item.Id });
                        if (foodChainFranchiseEntity != null)
                        {
                            foodChainFranchiseEntity.Address = item.Address;
                            foodChainFranchiseEntity.City = item.City;
                            foodChainFranchiseEntity.Country = item.Country;
                            foodChainFranchiseEntity.PinCode = item.PinCode;
                            foodChainFranchiseEntity.State = item.State;

                            await _unitOfWork.FoodChainFranchises.UpdateAsync(foodChainFranchiseEntity, new { @Id = item.Id });
                        }
                    }
                    return Ok("Franchises Updated Successfully.");
                }
            }
             return BadRequest();
        }


        [Route("UpdateFoodChainFranchises")]
        [HttpPut]
        public async Task<IActionResult> UpdateFoodChainFranchise(IEnumerable<FoodChainFranchiseModel> model)
        {

            if (model.Any())
            {
                foreach (var item in model)
                {
                    var foodChainFranchiseEntity = await _unitOfWork.FoodChainFranchises.GetDataByIdAsync(new { @Id = item.Id });
                    if (foodChainFranchiseEntity != null)
                    {
                        foodChainFranchiseEntity.Address = item.Address;
                        foodChainFranchiseEntity.City = item.City;
                        foodChainFranchiseEntity.Country = item.Country;
                        foodChainFranchiseEntity.PinCode = item.PinCode;
                        foodChainFranchiseEntity.State = item.State;

                        await _unitOfWork.FoodChainFranchises.UpdateAsync(foodChainFranchiseEntity, new { @Id = item.Id });
                    }
                }
                return Ok("Franchises Updated Successfully.");
            }
            return BadRequest();
        }

        [Route("RemoveFoodChainFranchise")]
        [HttpDelete]
        public async Task<IActionResult> DeleteFoodChainFranchise(int id)
        {
            return Ok(await _unitOfWork.FoodChainFranchises.RemoveAsync(new { @Id = id }));
        }
    }
}
