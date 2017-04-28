import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './components/app/app.component';
import { HomeComponent } from './components/home/home.component';
import { TestOverviewComponent } from './components/testoverview/testoverview.component';
import { HeaderComponent } from './components/shared/header/header.component';


@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        HomeComponent,
        HeaderComponent,
        TestOverviewComponent
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'testoverview/:id', component: TestOverviewComponent},
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModule {
}
