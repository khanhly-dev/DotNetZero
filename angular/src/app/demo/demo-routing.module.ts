import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AppRouteGuard } from '@shared/auth/auth-route-guard';
import { CityComponent } from './city/city.component';
import { TestComponent } from './test/test.component';

@NgModule({
    imports: [
        RouterModule.forChild([
            {path : 'city', component : CityComponent
            , data: { permission: 'Pages.DanhMuc.Tinh1' },
            canActivate: [AppRouteGuard]
        },
        {path : 'test', component : TestComponent
            // , data: { permission: 'Pages.DanhMuc.Tinh1' },
            // canActivate: [AppRouteGuard]
        }
        ])
    ],
    exports: [RouterModule]
})
export class Demo2RoutingModule { }
