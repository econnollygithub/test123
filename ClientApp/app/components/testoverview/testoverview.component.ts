import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Test } from '../../models';


@Component({
    selector: 'testoverview',
    templateUrl: 'testoverview.component.html',
    styleUrls: ['testoverview.component.css']
})

export class TestOverviewComponent {
    constructor(private _router: Router,
        private _activatedRoute: ActivatedRoute) {

    }

    testId: number = 0;
    currentTest: Test = null;
    testName: string = null;

    navigateHome() {
        this._router.navigate(["home"])
    }

    ngOnInit(): void {
        console.log('In OnInit');
        console.log(this._activatedRoute);
        this.testId = this._activatedRoute.snapshot.params['id'];
        this.testName = this._activatedRoute.snapshot.params['name'];

        console.log("id is " + this.testId);
        console.log("name is " + this.testName);

        //get the contents for the test

    };

}