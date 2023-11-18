import { Component, OnInit } from '@angular/core';
import { ShipmentsService } from '../../services/shipments.service';
import { Observable } from 'rxjs';
import { ShipmentOrder } from '../../model/ShipmentOrder';

@Component({
  selector: 'app-shipments-table',
  templateUrl: './shipments-table.component.html',
  styleUrls: ['./shipments-table.component.css'],
})
export class ShipmentsTableComponent implements OnInit {
  private shipmentOrders$: Observable<ShipmentOrder[]>;
  public shipments: ShipmentOrder[] = [];

  constructor(private shipmentService: ShipmentsService) {
    this.shipmentOrders$ = this.shipmentService.getShipmentOrders();
  }

  ngOnInit(): void {
    this.initTable();
  }

  public initTable() {
    this.shipmentOrders$.subscribe((result) => {
      this.shipments = result;
    });
  }
}
