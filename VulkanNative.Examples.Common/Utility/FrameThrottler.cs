using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace VulkanNative.Examples.Common.Utility;

public class FrameThrottler
{
    private const double DefaultErrorToleranceRatio = 0.05; // 5% tolerance

    private readonly Queue<long> _frameTimestamps = new();

    private long _targetFrameDuration;
    private long _lastFrameTimestamp;
    private long _error;
    private bool _isFirstFrame;
    private double _errorTolerance;

    public TimeSpan LastFrameDuration => TimeSpan.FromTicks(Stopwatch.GetTimestamp() - _lastFrameTimestamp);
    public TimeSpan TargetFrameDuration => TimeSpan.FromTicks(_targetFrameDuration);

    public double CurrentFPS => _frameTimestamps.Count;

    public FrameThrottler(double targetFrameRate)
    {
        SetTargetFrameRate(targetFrameRate);
        SetErrorToleranceRatio(DefaultErrorToleranceRatio);

        _lastFrameTimestamp = Stopwatch.GetTimestamp();
        _error = 0;
        _isFirstFrame = true;
    }

    public void SetTargetFrameRate(double targetFrameRate)
    {
        if (targetFrameRate <= 0)
            throw new ArgumentOutOfRangeException(nameof(targetFrameRate), "Target frame rate must be greater than 0.");

        _targetFrameDuration = (long)(Stopwatch.Frequency / targetFrameRate);
    }

    public void SetErrorToleranceRatio(double errorToleranceRatio)
    {
        if (errorToleranceRatio <= 0)
            throw new ArgumentOutOfRangeException(nameof(errorToleranceRatio), "Error tolerance ratio must be greater than 0.");

        _errorTolerance = (long)(_targetFrameDuration * errorToleranceRatio);
    }

    public void WaitForNextFrame()
    {
        if (_isFirstFrame)
        {
            _lastFrameTimestamp = Stopwatch.GetTimestamp();
            _isFirstFrame = false;
            return;
        }

        long currentTimeStamp = Stopwatch.GetTimestamp();
        long elapsedSinceLastFrame = currentTimeStamp - _lastFrameTimestamp;

        long waitDuration = _targetFrameDuration - elapsedSinceLastFrame + _error;

        if (waitDuration > 0)
        {
            var spinWait = new SpinWait();

            var goalStamp = currentTimeStamp + waitDuration;

            while (Stopwatch.GetTimestamp() < goalStamp)
            {
                // Use built in adaptive spinning behavior
                spinWait.SpinOnce();
            }

            var postWaitTimestamp = Stopwatch.GetTimestamp();
            _error += waitDuration - (postWaitTimestamp - currentTimeStamp);
        }

        if (Math.Abs(_error) > _errorTolerance)
        {
            _error = 0;
        }

        _lastFrameTimestamp = Stopwatch.GetTimestamp();

        _frameTimestamps.Enqueue(_lastFrameTimestamp);

        while (_frameTimestamps.Count > 0 && _lastFrameTimestamp - _frameTimestamps.Peek() > Stopwatch.Frequency)
        {
            _frameTimestamps.Dequeue();
        }
    }
}