import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ShipmentOrder } from '../model/ShipmentOrder';
import { ApiConfigService } from 'src/app/shared/services/api-config.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ShipmentsService {
  constructor(
    private httpClient: HttpClient,
    private apiConfig: ApiConfigService
  ) {}

  public getShipmentOrders(): Observable<ShipmentOrder[]> {
    const url = this.apiConfig.getApiUrl('shipmentOrders');
    return this.httpClient.get<ShipmentOrder[]>(url);
  }
}
