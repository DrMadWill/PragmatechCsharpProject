# Identity on ASP.NET Core
> İstiadəcinin qeydiyyatdan keçməsi, doğrulanmqası,silinməsi və ikili hesaba ikili doğrulama təbiq edilməsi və s kimi hallarda bizə dəstək olan **framework**dür.

## Authentication and Authorization
- _Authentication_ istifadəcinin doğruluğunu yoxlayır.
- _Authorization_ Userlər arasındakı qadağaları bizə göstərir



## Required Packages
- Install-Package Microsoft.AspNet.Identity.Core -Version 2.2.3
- Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -Version 3.1.1
> Context Classı `IdentityDbContext` classında Törədirik

## Startup.cs add AddIdentity() Method 
> 
```cs
   services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<PorfolioDbContext>();
```

## Change Default IdentityUser,IdentityRole
> İstəsək Sistemin bizə verdiyi userin və rolun propertylərinə yenisi əlavə edə bilərik. Bunu üçün ilk olaraq bir **User Model**i yaradırıq sonra **User**i   **IdentityUser** Classindan törədirdik. Və Contexdə bildirik
```cs 
 : IdentityDbContext<User>
```

## Service Configure<IdentityOptions>() Method
> Qeydiyyat və singin qadağaları( Parol və giriş qadağaları vs ə. )

```cs

 services.Configure<IdentityOptions>(options =>
    {
        // Password qadağaları
        options.Password.RequireDigit = true;// Rəqəm Mütləq olmalıdır.
        options.Password.RequiredLength = 8;// Minumum Uzunluq vs qadağalar vermək mükündür
        
        // Girişə verilən qadağalarıdır
        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);

    });

```












