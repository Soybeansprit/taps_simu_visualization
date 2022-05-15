package com.smarthome.util.counter;

import java.util.concurrent.atomic.AtomicLong;

public class CounterUtil implements com.smarthome.util.CounterUtil  {
    private AtomicLong count = new AtomicLong(0);

    public CounterUtil() {
    }

    public AtomicLong getCount() {
        return count;
    }

    public void setCount(AtomicLong count) {
        this.count = count;
    }

    @Override
    public  void addCount(){
        this.count.incrementAndGet();
    }

    @Override
    public String toString() {
        return "CounterUtil{" +
                "count=" + count +
                '}';
    }
}
