import { Component, OnInit } from '@angular/core';
import { Test } from '../../models';
import { ApiService } from '../../core';

import { Router } from '@angular/router';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'


})
export class HomeComponent implements OnInit {


    constructor(private _router: Router,
                private _apiService: ApiService) {
        
    }

    tests: any[] = [];
    errorMessage: any;

    navigateToTest() {
        this._router.navigate(["testoverview", "1234"])
    }

    ngOnInit(): void {
        console.log('In OnInit');
        this.refresh();
    }

    private refresh() {
        this.tests = [];
        //this.currentTEst = new TestUser();
        this._apiService.getTests()
            .subscribe(tests => {                           //function arg 1, success
                this.tests = tests;
                console.log("from component ");
                console.log(this.tests);
            }),
            error => this.errorMessage = <any>error;        //function arg 2 - error
    }
}

