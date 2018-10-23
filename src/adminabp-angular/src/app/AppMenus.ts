import { MenuItem } from '@yoyo/theme';

// 全局的左侧导航菜单
export class AppMenus {
    static Menus = [
        //测试菜单

        // 首页
        new MenuItem(
            'HomePage',
            '',
            'anticon anticon-home',
            '/app/home'
        ),
        // 租户
        new MenuItem(
            'Tenants',
            'Pages.Tenants',
            'anticon anticon-team',
            '/app/tenants',
        ),
        // 角色
        new MenuItem(
            'Roles',
            'Pages.Roles',
            'anticon anticon-safety',
            '/app/roles',
        ),
        new MenuItem('PhoneBooks', 'Pages.Person', 'anticon anticon-book', '', [ //人员
            new MenuItem('Persons', 'Pages.Person', 'anticon anticon-dashboard', '/app/persons'),
            //电话
            new MenuItem('PhoneNumbers', 'Pages.PhoneNumber', 'anticon anticon-phone', '/app/phones')], true, true, true, false, true),

        // 用户
        new MenuItem(
            'Users',
            'Pages.Users',
            'anticon anticon-user',
            '/app/users',
        ),
        // 关于我们
        new MenuItem(
            'About',
            '',
            'anticon anticon-info-circle-o',
            '/app/about',
        ),
    ];
}