export class ApiResponse<T> {
  constructor(
    public statusCode: number,
    public message: string,
    public data: T | null = null,
    public errors: string[] = []
  ) {}
}