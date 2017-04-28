import { ResponseType } from './responseType.enum';

export class QuestionResponse {
    QuestionId: number;
    ResponseText: string;
    ResponseType: ResponseType;
}