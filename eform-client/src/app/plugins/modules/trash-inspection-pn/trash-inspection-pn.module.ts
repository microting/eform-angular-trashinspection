import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {FormsModule} from '@angular/forms';
import {TranslateModule} from '@ngx-translate/core';
import {MDBBootstrapModule} from 'port/angular-bootstrap-md';
import {NgSelectModule} from '@ng-select/ng-select';

import {
  TrashInspectionPnFractionsService,
  TrashInspectionPnInstallationsService,
  TrashInspectionPnTrashInspectionsService,
  TrashInspectionPnSettingsService,
  TrashInspectionPnTransporterService,
  TrashInspectionPnProducersService,
  TrashInspectionPnSegmentsService
} from './services';
import {TrashInspectionPnLayoutComponent} from './layouts';
import {TrashInspectionPnRouting} from './trash-inspection-pn.routing.module';
import {SharedPnModule} from '../shared/shared-pn.module';
// import {StatusBarComponent} from '../../../common/modules/eform-shared/components';
import {EformSharedModule} from '../../../common/modules/eform-shared/eform-shared.module';

import {
  FractionCreateComponent,
  FractionDeleteComponent,
  FractionEditComponent,
  FractionsPageComponent,
  FractionsPnImportComponent,
  InstallationCreateComponent,
  InstallationDeleteComponent,
  InstallationsPageComponent,
  InstallationEditComponent,
  TrashInspectionCreateComponent,
  TrashInspectionDeleteComponent,
  TrashInspectionsPageComponent,
  TrashInspectionEditComponent,
  TrashInspectionSettingsComponent,
  SegmentCreateComponent,
  SegmentDeleteComponent,
  SegmentEditComponent,
  SegmentsPageComponent,
  ProducerPageComponent,
  ProducerCreateComponent,
  ProducerDeleteComponent,
  ProducerEditComponent,
  ProducerImportComponent,
  TransporterPageComponent,
  TransporterCreateComponent,
  TransporterDeleteComponent,
  TransporterEditComponent,
  TransporterImportComponent
} from './components';

@NgModule({
  imports: [
    CommonModule,
    SharedPnModule,
    MDBBootstrapModule,
    TrashInspectionPnRouting,
    TranslateModule,
    FormsModule,
    NgSelectModule,
    EformSharedModule
  ],
  declarations: [
    InstallationsPageComponent,
    InstallationDeleteComponent,
    InstallationCreateComponent,
    InstallationEditComponent,
    TrashInspectionsPageComponent,
    TrashInspectionCreateComponent,
    TrashInspectionEditComponent,
    TrashInspectionDeleteComponent,
    TrashInspectionPnLayoutComponent,
    TrashInspectionSettingsComponent,
    FractionCreateComponent,
    FractionDeleteComponent,
    FractionEditComponent,
    FractionsPnImportComponent,
    FractionsPageComponent,
    SegmentCreateComponent,
    SegmentDeleteComponent,
    SegmentEditComponent,
    SegmentsPageComponent,
    ProducerPageComponent,
    ProducerCreateComponent,
    ProducerDeleteComponent,
    ProducerEditComponent,
    ProducerImportComponent,
    TransporterPageComponent,
    TransporterCreateComponent,
    TransporterDeleteComponent,
    TransporterEditComponent,
    TransporterImportComponent
  ],
  providers: [TrashInspectionPnFractionsService,
              TrashInspectionPnInstallationsService,
              TrashInspectionPnTrashInspectionsService,
              TrashInspectionPnSegmentsService,
              TrashInspectionPnSettingsService,
              TrashInspectionPnTransporterService,
              TrashInspectionPnProducersService
  ]
})
export class TrashInspectionPnModule { }
