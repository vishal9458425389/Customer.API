﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMI.Customers.Domain.Entities;
using EMI.Customers.Domain.Enums;
using EMI.Customers.Domain.Models;

namespace EMI.Customers.Domain.Services
{
	public static class CustomerDataStore
	{
		public static List<Item> Items { get; set; }=new List<Item>
		{
			 
			new Item()
			{
				Id = 1,
				Name = "bfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfbfhjhjjhjhjhnjnjnhjnj",
				Cost = 8900
			},
			new Item()
			{
				Id = 2,
				Name = "TShirt",
				Cost = 10000
			},
			new Item()
			{
				Id = 2,
				Name = "Shirts",
				Cost = 20000
			},

			
			new Item()
			{
				Id = 3,
				Name = "WaterBottles",
				Cost = 400
			}
		};

		public static List<ItemDto> ItemsDto { get; set; } = new List<ItemDto>
		{

			new ItemDto()
			{
				Id = 1,
				Name = "NokiaLumia",
				Cost = 8900
			},
			new ItemDto()
			{
				Id = 2,
				Name = "TShirt",
				Cost = 10000
			},
			new ItemDto()
			{
				Id = 2,
				Name = "Shirts",
				Cost = 20000
			},


			new ItemDto()
			{
				Id = 3,
				Name = "WaterBottles",
				Cost = 400
			}
		};


		public static IEnumerable<Customer> Customers { get; set; } = new List<Customer>()
		{
			new Customer()
			{
				Id = 1,
				Name = "Vishal",
				Address = "Bareilly",
				CustomerType = CustomerType.DiamondCustomer
			},
			new Customer()
			{
				Id = 2,
				Name = "Sumit",
				Address = "Bihar",
				CustomerType = CustomerType.GoldCustomer
			},
			new Customer()
			{
				Id = 3,
				Name = "Prasobh",
				Address = "Wayanad",
				CustomerType = CustomerType.SilverCustomer
			}
		};

		public static async Task<IEnumerable<Item>> GetItemsAsync()
		{
			return Items;
		}

		public static async Task<Item> GetItemAsync(int itemId)
		{
			return Items.FirstOrDefault(i=>i.Id==itemId);
		}
	}
}