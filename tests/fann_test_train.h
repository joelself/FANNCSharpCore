#ifndef FANN_FANN_TEST_TRAIN_H
#define FANN_FANN_TEST_TRAIN_H

#include "fann_test.h"

class FannTestTrain : public FannTest {
protected:
    double xorInput[8] = {
            0.0, 0.0,
            0.0, 1.0,
            1.0, 0.0,
            1.0, 1.0};
    double xorOutput[4] = {
            0.0,
            1.0,
            1.0,
            0.0};

    virtual void SetUp();

    virtual void TearDown();
};

#endif
