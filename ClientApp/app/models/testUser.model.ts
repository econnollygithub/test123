import { TestResult } from './testResult.model';

export class TestUser {
    UserId: number;
    FirstName: string;
    LastName: string;
    CurrentResults: [TestResult];
}