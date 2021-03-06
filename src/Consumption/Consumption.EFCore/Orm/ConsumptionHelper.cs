﻿/*
*
* 文件名    ：ConsumptionHelper                             
* 程序说明  : 数据库上下文帮助类
* 更新时间  : 2020-05-22 13：48
* 更新人    : zhouhaogg789@outlook.com
* 
*
*/


namespace Consumption.EFCore.Orm
{
    using Consumption.Core.Entity;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// 数据库上下文帮助类
    /// </summary>
    public class ConsumptionHelper
    {
        /// <summary>
        /// 初始化样本数据
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static async Task InitSampleDataAsync(ConsumptionContext context)
        {
            if (!context.Users.Any())
            {
                List<User> userList = new List<User>();
                userList.Add(new User() { Account = "Test", UserName = "测试员", Address = "Guangzhou", Tel = "1870620584", CreateTime = DateTime.Now });
                userList.Add(new User() { Account = "Abigail", UserName = "愛比蓋爾", Address = "Guangzhou", Tel = "1870620584", CreateTime = DateTime.Now });
                userList.Add(new User() { Account = "Ada", UserName = "愛達", Address = "Guangzhou", Tel = "1870620584", CreateTime = DateTime.Now });
                userList.Add(new User() { Account = "Agatha", UserName = "阿加莎", Address = "Guangzhou", Tel = "1870620584", CreateTime = DateTime.Now });
                userList.Add(new User() { Account = "Diana", UserName = "黛安娜", Address = "Guangzhou", Tel = "1870620584", CreateTime = DateTime.Now });
                userList.Add(new User() { Account = "Eliza", UserName = "伊萊扎", Address = "Guangzhou", Tel = "1870620584", CreateTime = DateTime.Now });
                userList.Add(new User() { Account = "弗洛拉", UserName = "Flora", Address = "Guangzhou", Tel = "1870620584", CreateTime = DateTime.Now });
                userList.ForEach(async arg => await context.Users.AddAsync(arg));

                List<Menu> menuList = new List<Menu>();
                menuList.Add(new Menu() { MenuCode = "1001", MenuName = "基础数据", MenuCaption = "", MenuNameSpace = "", });
                menuList.Add(new Menu() { MenuCode = "1002", MenuName = "用户管理", MenuCaption = "", MenuNameSpace = "", });
                menuList.Add(new Menu() { MenuCode = "1003", MenuName = "菜单管理", MenuCaption = "", MenuNameSpace = "", });
                menuList.Add(new Menu() { MenuCode = "1004", MenuName = "权限管理", MenuCaption = "", MenuNameSpace = "", });
                menuList.Add(new Menu() { MenuCode = "1005", MenuName = "计划管理", MenuCaption = "", MenuNameSpace = "", });
                menuList.Add(new Menu() { MenuCode = "1006", MenuName = "消费报表", MenuCaption = "", MenuNameSpace = "", });
                menuList.Add(new Menu() { MenuCode = "1007", MenuName = "消费管理", MenuCaption = "", MenuNameSpace = "", });
                menuList.Add(new Menu() { MenuCode = "1008", MenuName = "消费管理", MenuCaption = "", MenuNameSpace = "", });
                menuList.Add(new Menu() { MenuCode = "1009", MenuName = "账户管理", MenuCaption = "", MenuNameSpace = "", });
                menuList.Add(new Menu() { MenuCode = "1010", MenuName = "我的账单", MenuCaption = "", MenuNameSpace = "", });
                menuList.ForEach(async arg => await context.Menus.AddAsync(arg));
                await context.SaveChangesAsync();
            }
        }
    }
}
