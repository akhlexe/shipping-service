import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class ApiConfigService {
  private baseUrl = environment.ApiUrl;

  getApiUrl(endpoint: string): string {
    return `${this.baseUrl}/${endpoint}`;
  }

  getApiUrlWithQueryParams(
    endpoint: string,
    params: Record<string, string>
  ): string {
    const url = `${this.baseUrl}/${endpoint}`;
    const queryString = Object.keys(params)
      .map((key) => `${key}=${params[key]}`)
      .join('&');

    return queryString ? `${url}?${queryString}` : url;
  }
}
