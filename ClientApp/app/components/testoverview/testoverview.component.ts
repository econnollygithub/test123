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

    navigateHome() {
        this._router.navigate(["home"])
    }

    ngOnInit(): void {
        console.log('In OnInit');
        this.testId = this._activatedRoute.snapshot.params['id'];

        //get the contents for the test

    };

}