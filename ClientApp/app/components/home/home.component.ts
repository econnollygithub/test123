import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {


    constructor(private _router: Router) {
        
    }

    navigateToTest() {
        this._router.navigate(["testoverview", "1234"])
    }
}

