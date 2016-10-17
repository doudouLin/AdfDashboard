//(function () {
//    'use strict';

//    //angular.module('Samples', [
//    //    'adf'
//    //])
//    //.controller('sampleCtrl', ['$scope', '$location', '$rootScope', '$routeParams', 'DashboardsFactory', 'dashboardInfo', function ($location, $rootScope, $scope, $routeParams, DashboardsFactory, dashboardInfo) {
//    //    //$scope.Dashboards.$promise.then(function (data) {
//    //    //    console.log('am I last');
//    //    //    console.log(data[1]);
//    //    //    structure = data[1].structure;
//    //    //    name = data[1].name;
//    //    //    title = data[1].title;
//    //    //});
//    //    //$scope.dashboard = DashboardsFactory.GetDashboardById({ dashboardId: 2 });
//    //    console.log('this is resulat');
//    //    console.log(dashboardInfo);
//    //    this.name = $routeParams.id;
//    //    this.collapsible = data.collapsible;
//    //    this.maximizable = data.maximizable;
//    //    this.categories = data.categories;

//    //    var model = {
//    //        title: data.title,
//    //        structure: data.structure,
//    //        rows: [{
//    //            columns: [{
//    //                styleClass: "col-md-4",
//    //                widgets: [{
//    //                    fullScreen: false,
//    //                    modalSize: 'lg',
//    //                    type: "clock",
//    //                    config: {
//    //                        timePattern: 'HH:mm:ss',
//    //                        datePattern: 'YYYY-MM-DD'
//    //                    },
//    //                    title: "AHAHAH"
//    //                }]
//    //            }, {
//    //                styleClass: "col-md-8",
//    //                widgets: [{
//    //                    fullScreen: false,
//    //                    modalSize: 'sm',
//    //                    type: "clock",
//    //                    config: {
//    //                        timePattern: 'HH:mm:ss',
//    //                        datePattern: 'YYYY-MM-DD'
//    //                    },
//    //                    title: "Github Author"
//    //                }, {
//    //                    fullScreen: true,
//    //                    //modalSize: 'lg',
//    //                    type: "clock",
//    //                    config: {
//    //                        timePattern: 'HH:mm:ss',
//    //                        datePattern: 'YYYY-MM-DD'
//    //                    },
//    //                    title: "Github History"
//    //                }]
//    //            }]
//    //        }]
//    //    };

//    //    this.model = model;


//    //    var eventFired = function (event, name, model) {
//    //        //console.log($scope.model.structure);
//    //        console.log(event);

//    //    };

//    //    var widgetAddeventFired = function (event, name, model, widget) {
//    //        //console.log($scope.model.structure);
//    //        console.log(widget);
//    //        console.log(model);
//    //    };

//    //    $scope.$on('adfDashboardChanged', eventFired);
//    //    $scope.$on('adfWidgetAdded', widgetAddeventFired);
//    //    $scope.$on('adfWidgetMoved', eventFired);
//    //    $scope.$on('adfWidgetAddedToColumn', eventFired);
//    //    $scope.$on('adfWidgetRemovedFromColumn', eventFired);
//    //    $scope.$on('adfWidgetMovedInColumn', eventFired);
//    //}]);
//})();