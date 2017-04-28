import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'testoverview',
    templateUrl: 'testoverview.component.html',
    styleUrls: ['testoverview.component.css']
})
export class TestOverviewComponent {
    constructor(private _router: Router) {
    }

    navigateHome() {
        this._router.navigate(["home"])
    }
}