import { TestType } from './testType.model';
import { TestPage } from './testPage.model';

export class Test {
    TestId: number;
    TestName: string
    TestDifficulty: number;
    TestType: TestType;
    TestPages: TestPage;
}