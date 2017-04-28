import { QuestionResponse } from './questionResponse.model';

export class TestQuestion  {
    QuestionId: number;
    QuestionText: string;
    QuestionResponses: [QuestionResponse]
}