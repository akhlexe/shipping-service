import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { CreateOrderComponent } from './components/create-order/create-order.component';
import { ShipmentsComponent } from './shipments.component';

@NgModule({
  declarations: [ShipmentsComponent, CreateOrderComponent],
  imports: [CommonModule, HttpClientModule],
})
export class ShipmentsModule {}
