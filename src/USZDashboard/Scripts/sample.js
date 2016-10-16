(function () {
    'use strict';

    angular.module('Sample', [
        'adf'
    ]);
    //.controller('sampleCtrl', ['$scope', function ($scope) {
    //    //$scope.Dashboards.$promise.then(function (data) {
    //    //    console.log('am I last');
    //    //    console.log(data[1]);
    //    //    structure = data[1].structure;
    //    //    name = data[1].name;
    //    //    title = data[1].title;
    //    //});

    //    model = {
    //        title: 'Lin DS Title',
    //        structure: '4-8',
    //        rows: [{
    //            columns: [{
    //                styleClass: "col-md-4",
    //                widgets: [{
    //                    fullScreen: false,
    //                    modalSize: 'lg',
    //                    type: "clock",
    //                    config: {
    //                        timePattern: 'HH:mm:ss',
    //                        datePattern: 'YYYY-MM-DD'
    //                    },
    //                    title: "AHAHAH"
    //                }]
    //            }, {
    //                styleClass: "col-md-8",
    //                widgets: [{
    //                    fullScreen: false,
    //                    modalSize: 'sm',
    //                    type: "clock",
    //                    config: {
    //                        timePattern: 'HH:mm:ss',
    //                        datePattern: 'YYYY-MM-DD'
    //                    },
    //                    title: "Github Author"
    //                }, {
    //                    fullScreen: true,
    //                    //modalSize: 'lg',
    //                    type: "clock",
    //                    config: {
    //                        timePattern: 'HH:mm:ss',
    //                        datePattern: 'YYYY-MM-DD'
    //                    },
    //                    title: "Github History"
    //                }]
    //            }]
    //        }]
    //    };
    //    $scope.name = 'Lin ds';
    //    $scope.model = model;
    //    $scope.collapsible = false;
    //    $scope.maximizable = false;
    //    $scope.categories = true;

    //    var eventFired = function (event, name, model) {
    //        //console.log($scope.model.structure);
    //        console.log(event);

    //    };

    //    var widgetAddeventFired = function (event, name, model, widget) {
    //        //console.log($scope.model.structure);
    //        console.log(widget);
    //        console.log(model);
    //    };

    //    $scope.$on('adfDashboardChanged', eventFired);
    //    $scope.$on('adfWidgetAdded', widgetAddeventFired);
    //    $scope.$on('adfWidgetMoved', eventFired);
    //    $scope.$on('adfWidgetAddedToColumn', eventFired);
    //    $scope.$on('adfWidgetRemovedFromColumn', eventFired);
    //    $scope.$on('adfWidgetMovedInColumn', eventFired);
    //}]);
})();